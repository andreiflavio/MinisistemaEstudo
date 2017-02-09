using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Modelo
{
    public class ClassSQLFormat
    {
        /// <summary>
        /// Formata update de todos campos (padrão POST)
        /// </summary>
        /// <typeparam name="T"> Classe definida em tempo de execução</typeparam>
        /// <param name="Obj"> objeto base para criação da senteça SQL</param>
        /// <returns>senteça update</returns>
        public string SQLUpdate<T>(T Obj)
        {
            PropertyInfo[] props = Obj.GetType().GetProperties();
            string camposValue = String.Empty;
            string sql = @"UPDATE {0} SET {1} WHERE {2}";
            for (int i = 1; i < props.Count(); i++)
            {
                if (!IsColumn(props[i]))
                    continue;
                camposValue += getCamposUpdate(props[i], Obj);
                if (i != props.Count() - 1)
                    camposValue += ", ";
            }
            sql = String.Format(sql, Obj.GetType().Name.ToString().Substring(0, Obj.GetType().Name.Length - 3), camposValue, props[0].Name + "=" + Convert.ToString(props[0].GetValue(Obj, null).ToString()));
            return sql;
        }

        /// <summary>
        /// Formata update apenas dos campos alterados (padrão PATCH)
        /// </summary>
        /// <typeparam name="T"> Classe definida em tempo de execução</typeparam>
        /// <param name="registroAlterado">Objeto com as alterações a serem persistidas no banco</param>
        /// <param name="registroSemAlteracao"> Registro recuperado do banco para saber quais campos foram alterados pelo usuário</param>
        /// <returns> senteça update</returns>
        public string SQLUpdate<T>(T registroAlterado, T registroSemAlteracao)
        {
            PropertyInfo[] propsRegistroAlterado = registroAlterado.GetType().GetProperties();
            PropertyInfo[] propsRegistroSemAlteracao = registroSemAlteracao.GetType().GetProperties();
            string camposValue = String.Empty;
            string sql = @"UPDATE {0} SET {1} WHERE {2}";
            for (int i = 1; i < propsRegistroAlterado.Count(); i++)
            {
                if ((!IsColumn(propsRegistroAlterado[i])) || (propsRegistroSemAlteracao[i].GetValue(registroSemAlteracao, null).Equals(propsRegistroAlterado[i].GetValue(registroAlterado, null))))
                    continue;
                camposValue += getCamposUpdate(propsRegistroAlterado[i], registroAlterado);
                if (i != propsRegistroAlterado.Count() - 1)
                    camposValue += ", ";
            }
            if (string.IsNullOrEmpty(camposValue))
                throw new Exception(" Não houve alteração no registro. ");
            if (camposValue.Substring(camposValue.Length - 2).Contains(","))
                camposValue = camposValue.Remove(camposValue.Length - 2, 2);
            sql = String.Format(sql, registroAlterado.GetType().Name.ToString().Substring(0, registroAlterado.GetType().Name.Length - 3), camposValue, propsRegistroAlterado[0].Name + "=" + Convert.ToString(propsRegistroAlterado[0].GetValue(registroAlterado, null).ToString()));
            return sql;
        }

        /// <summary>
        /// Formata sentença de inserção (padrão POST)
        /// </summary>
        /// <typeparam name="T"> Classe a ser definida em tempo de execução</typeparam>
        /// <param name="Obj"> objeto base para montagem da sentença SQL</param>
        /// <returns>senteça de inserção</returns>
        public string SQLInsert<T>(T Obj)
        {
            PropertyInfo[] props = Obj.GetType().GetProperties();
            string camposSql = String.Empty;
            string camposValue = String.Empty;
            string sql = @"INSERT INTO {0} ({1})  VALUES({2})";            
            for (int i = 1; i < props.Count(); i++)
            {
                if (!IsColumn(props[i]))                
                    continue;               
                if (props[i].PropertyType == typeof(string))
                    camposValue += "'" + Convert.ToString(props[i].GetValue(Obj, null).ToString()) + "'";
                else if (props[i].PropertyType == typeof(DateTime))
                {
                    string[] dataFormatada = Convert.ToDateTime(props[i].GetValue(Obj, null)).GetDateTimeFormats();
                    camposValue += "'" + dataFormatada[33] + "'";
                }
                else if (props[i].PropertyType == typeof(decimal))
                {
                    string campoFormatado = Convert.ToString(props[i].GetValue(Obj, null).ToString().Replace(",", "."));
                    camposValue += campoFormatado;
                }
                else camposValue += Convert.ToString(props[i].GetValue(Obj, null).ToString());
                if (i != 1)
                {
                    camposSql = camposSql + ", " + props[i].Name;
                    if (i != props.Count() - 1)
                        camposValue = camposValue + ", ";
                }
                else
                {
                    camposSql = camposSql + props[i].Name;
                    if (props.Count() > 2)
                        camposValue = camposValue + ", ";
                }
            }
            if (camposValue.Substring(camposValue.Length - 2, 1)  == ",") 
                camposValue = camposValue.Replace(camposValue, camposValue.Substring(0, camposValue.Length - 2));
            sql = String.Format(sql, Obj.GetType().Name.ToString().Substring(0, Obj.GetType().Name.Length - 3), camposSql, camposValue);
            return sql;
        }

        /// <summary>
        /// Formata sentença delete (padrão DELETE)
        /// </summary>
        /// <typeparam name="T"> Classe a ser definida em tempo de execução</typeparam>
        /// <param name="Obj"> objeto base para sentença delete</param>
        /// <returns>senteça de exclusão</returns>
        public string SQLDelete<T>(T Obj)
        {
            PropertyInfo[] props = Obj.GetType().GetProperties();
            string sql = @"DELETE FROM {0} WHERE {1}";
            return String.Format(sql, Obj.GetType().Name.ToString().Substring(0, Obj.GetType().Name.Length - 3), props[0].Name + "=" + Convert.ToString(props[0].GetValue(Obj, null).ToString()));
        }

        /// <summary>
        /// Formata query a ser executada para recuperação de registros (padrão GET)
        /// </summary>
        /// <typeparam name="T">Classe a ser definida em tempo de execução</typeparam>
        /// <param name="props">Propriedades base para montagem do SQL</param>
        /// <param name="tableName">Nome da tabela</param>
        /// <param name="campofiltro">Campo a ser utilizado no filtro</param>
        /// <param name="texto_filtro">Texto a ser utilizado na filtragem dos registros</param>
        /// <returns>Query formatada</returns>
        public string SQLSelect<T>(PropertyInfo[] props, string tableName, string campofiltro, string texto_filtro)
        {
            #region variáveis
            int i = 0;
            string sqlSelect = @"SELECT {0} FROM {1} (NOLOCK) WHERE {2}";            
            string camposSql = string.Empty;
            string operador = string.Empty;            
            #endregion

            for (i = 0; i < props.Count(); i++)
            {
                if (!IsColumn(props[i]))
                    continue;
                if (i == 0)
                    camposSql = props[i].Name;
                else camposSql = camposSql + ", " + props[i].Name;
                if ((campofiltro == "ID") && (i == 0))
                    campofiltro = props[0].Name;
                if (campofiltro == props[i].Name)
                {
                    if (props[i].PropertyType == typeof(string))
                        operador = " Like '{0}%' ";
                    else if (props[i].PropertyType == typeof(DateTime))
                    {
                        texto_filtro = String.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(texto_filtro));
                        operador = " = #{0}# ";
                    }
                    else
                    {
                        operador = " = {0} ";
                    }
                }
            }

            string clauslaWHERE = (((campofiltro != String.Empty) && (texto_filtro != string.Empty)) ? string.Format(campofiltro + operador, texto_filtro) : ("1=1"));
            sqlSelect = string.Format(sqlSelect, camposSql, tableName, clauslaWHERE) + " ORDER BY " + props[0].Name;
            return sqlSelect.ToUpper();
        }

        public bool IsColumn(PropertyInfo props)
        {
            object[] atributosMembro = props.GetCustomAttributes(typeof(System.Data.Linq.Mapping.ColumnAttribute), false);
            return atributosMembro.Count() > 0;
        }

        private string getCamposUpdate(PropertyInfo props, object obj)
        {
            string camposValue = string.Empty;
            if (props.PropertyType == typeof(string))
                camposValue += props.Name + "=" + "'" + Convert.ToString(props.GetValue(obj, null).ToString()) + "'";
            else if (props.PropertyType == typeof(DateTime))
            {
                string[] dataFormatada = Convert.ToDateTime(props.GetValue(obj, null)).GetDateTimeFormats();
                camposValue += props.Name + "=" + "'" + dataFormatada[33] + "'";
            }
            else if (props.PropertyType == typeof(decimal))
            {
                string campoFormatado = Convert.ToString(props.GetValue(obj, null).ToString().Replace(",", "."));
                camposValue += props.Name + "=" + "'" + campoFormatado + "'";
            }
            else camposValue += props.Name + "=" + Convert.ToString(props.GetValue(obj, null).ToString());
            return camposValue;
        }
    }
}
