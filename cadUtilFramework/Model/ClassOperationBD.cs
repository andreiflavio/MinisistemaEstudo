using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace Modelo
{
    public class ClassOperationBD
    {
        /// <summary>
        /// Bancos de dados suportados pelo sistema
        /// </summary>
        public enum DataBases
        {
            SQLServer,
            Acess,
            MySQL,
            SQLite
        }

        /// <summary>
        /// Operações de CRUD
        /// </summary>
        public enum Operacao
        {
            Insert,
            Delete,
            Update,
            Read
        }

        private DataBases dataBase;
        public ClassOperationBD()
        {
            XElement xml = XElement.Load("Config.xml");
            foreach (XElement x in xml.Elements())
            {
                dataBase = (DataBases)Enum.Parse(typeof(DataBases), x.Attribute("BancodeDadosSelecionado").Value);
            }

        }

        /// <summary>
        /// instância da classe responsável por criar os comandos crud.
        /// </summary>
        private ClassSQLFormat SqlFormat
        {
            get
            {
                if (_sqlFormat == null)
                    _sqlFormat = new ClassSQLFormat();
                return _sqlFormat;
            }
        }
        private ClassSQLFormat _sqlFormat;

        /// <summary>
        /// Seleciona o banco de dados a ser utilizado
        /// </summary>
        /// <param name="DataBasesSuported">Qual banco deverá ser suportado pelo sistema</param>
        /// <returns>Banco Suportado</returns>
        public ClassConnection SelectDataBase(DataBases DataBasesSuported)
        {
            ClassConnection connection = null;
            switch (DataBasesSuported)
            {
                case DataBases.SQLServer:
                    {
                        connection = new ClassSQLConnection();
                        break;
                    }
                case DataBases.Acess:
                    {
                        connection = new ClassAcessConnection();
                        break;
                    }
                case DataBases.MySQL:
                    {
                        connection = new ClassMySQLConnection();
                        break;
                    }
                case DataBases.SQLite:
                    {
                        connection = new ClassSQLiteConnection();
                        break;
                    }
                default:
                    {
                        throw new Exception("Não há suporte para este banco de dados.");
                    }
            }
            return connection;
        }

        /// <summary>
        /// Método para persistir os dados no banco
        /// </summary>
        /// <typeparam name="T"> Classe base a ser definida em tempo de execução</typeparam>
        /// <param name="ListaObj"> Lista de objetos a serem persistidos no banco de dados</param>
        /// <param name="operacao"> Qual operação de persistência de dados será feita (UPDATE, INSERT ou DELETE)</param>
        /// <param name="executarXVezes"> Quantidade de vezes que a operação deverá ser executada para a mesma massa de dados.</param>
        /// <returns>retorna true se a operação ocorreu com sucesso</returns>
        public bool Commit<T>(List<T> ListaObj, Operacao operacao, int executarXVezes) where T : new()
        {
            bool save = true;
            #region Execução do comando montado a partir do objeto passado
            using (ClassConnection conn = SelectDataBase(dataBase))
            {
                conn.AbrirConexao();
                try
                {
                    for (int j = 0; j < executarXVezes; j++)
                    {
                        foreach (T obj in ListaObj)
                        {
                            string sentencasSQL = getSentencaSQL<T>(operacao, obj);
                            conn.ExecuteNonQuery(sentencasSQL);
                        }
                    }
                }
                catch (Exception e)
                {
                    save = false;
                    throw new Exception(e.Message);
                }
                conn.FecharConexao();
            }
            #endregion
            return save;
        }

        /// <summary>
        /// Método para retornar uma lista de objetos carregados com os dados do banco.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">objeto base para montagem da consulta</param>
        /// <param name="texto_filtro">texto a ser inserido no filtro da query</param>
        /// <param name="campofiltro"> campo a ser usado no filtro da query</param>
        /// <param name="sqlMontado">Se este parâmetro possui valor, a informação dele é utilizada na query, ignorando os demais parâmetros. Apenas querys completas devem ser passadas neste parâmetro</param>
        /// <returns>Lista de objetos com os dados do banco de dados.</returns>
        public List<T> getRegistros<T>(T obj, string texto_filtro, string campofiltro, string sqlMontado = "") where T : new()
        {
            string sql = sqlMontado;
            if (String.IsNullOrEmpty(sql))
                sql = SqlFormat.SQLSelect<T>(obj.GetType().GetProperties(), obj.GetType().Name.ToString().Substring(0, obj.GetType().Name.Length - 3), campofiltro, texto_filtro);
            Trace.WriteLine("Query executada para leitura de registros:\n " + sql);
            List<T> lista = new List<T>();
            using (ClassConnection conn = SelectDataBase(dataBase))
            {
                conn.AbrirConexao();
                if (!((dataBase == DataBases.Acess) || (dataBase == DataBases.SQLServer)))
                    sql = sql.Replace("(NOLOCK)", string.Empty);
                DbDataReader reader = conn.ExecuteReader(sql);
                while (reader.Read())
                {
                    obj = Activator.CreateInstance<T>();
                    foreach (PropertyInfo prop in obj.GetType().GetProperties())
                    {
                        if (SqlFormat.IsColumn(prop))
                        {
                            if (!object.Equals(reader[prop.Name], DBNull.Value))
                            {
                                if (reader[prop.Name].GetType() == typeof(Double))
                                    prop.SetValue(obj, String.Format("{0:C}", reader[prop.Name]), null);
                                else if (reader[prop.Name].GetType() == typeof(DateTime))
                                {
                                    if (dataBase == DataBases.Acess)
                                        prop.SetValue(obj, String.Format("{0:dd/MM/yyyy}", reader[prop.Name]), null);
                                    else
                                    {
                                        string[] dataFormatada = Convert.ToDateTime(reader[prop.Name]).GetDateTimeFormats();
                                        prop.SetValue(obj, Convert.ToDateTime(dataFormatada[0]), null);
                                    }
                                }
                                else prop.SetValue(obj, reader[prop.Name], null);
                            }
                        }
                    }
                    lista.Add(obj);
                }
                conn.FecharConexao();
            }
            return lista;
        }

        private string getSentencaSQL<T>(Operacao operacao, T obj) where T : new()
        {
            string sentencasSQL = string.Empty;
            switch (operacao)
            {
                case Operacao.Insert:
                    {
                        sentencasSQL = SqlFormat.SQLInsert<T>(obj);
                        Trace.WriteLine("Sentença para inserção do registro:\n " + sentencasSQL);
                        break;
                    }
                case Operacao.Update:
                    {
                        string textofiltro = obj.GetType().GetProperties()[0].GetValue(obj, null).ToString();
                        Trace.WriteLine("Query para recupar o registro a ser alterado. ");
                        List<T> lista = getRegistros<T>((new T()), textofiltro, "ID");
                        sentencasSQL = SqlFormat.SQLUpdate<T>(obj, lista[0]);
                        Trace.WriteLine("Senteça  de atualização montada a partir dos camops alterados no cadastro:\n " + sentencasSQL);
                        break;
                    }
                case Operacao.Delete:
                    {
                        sentencasSQL = SqlFormat.SQLDelete<T>(obj);
                        Trace.WriteLine("Senteça para exclusão do registro:\n " + sentencasSQL);
                        break;
                    }
                default:
                    {
                        throw new Exception("ERRO ao montar senteça SQL. Operação não suportada.");
                    }
            }
            return sentencasSQL.ToUpper();
        }
    }
}
