using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Data.OleDb;
using System.ComponentModel.DataAnnotations;
using Modelo;
using System.Diagnostics;

namespace Controlador
{
    public class ClassController
    {
        private ClassOperationBD SqlOperationBD
        {
            get
            {
                if (_sqlOperationBD == null)
                    _sqlOperationBD = new ClassOperationBD();
                return _sqlOperationBD;
            }
        } private ClassOperationBD _sqlOperationBD;

        /// <summary>
        /// Método para montagem da lista a ser exibida no grid.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="campofiltro"></param>
        /// <param name="texto_filtro"></param>
        /// <returns></returns>
        public List<T> getRegistros<T>(string campofiltro, string texto_filtro) where T : new()
        {

            T obj = new T();
            List<T> lista = SqlOperationBD.getRegistros<T>(obj, texto_filtro, campofiltro);
            return lista;
        }

        /// <summary>
        /// método que insere ou atualiza dados no banco
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Obj"></param>
        /// <param name="IsInsert"></param>
        /// <returns></returns>
        public bool Save<T>(T Obj, Boolean IsInsert) where T : new()
        {
            ValidationErros(Obj);
            List<T> ListaObj = new List<T> { Obj };
            return SqlOperationBD.Commit<T>(ListaObj, IsInsert ? Modelo.ClassOperationBD.Operacao.Insert : Modelo.ClassOperationBD.Operacao.Update, 1);
        }

        /// <summary>
        /// método que insere ou atualiza dados no banco em massa
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Lista"></param>
        /// <param name="IsInsert"></param>
        /// <returns></returns>
        public bool Save<T>(List<T> Lista, Boolean IsInsert) where T : new()
        {
            for (int i = 0; i < Lista.Count; i++)
            {
                ValidationErros(Lista[i]);
            }
            return SqlOperationBD.Commit<T>(Lista, IsInsert ? Modelo.ClassOperationBD.Operacao.Insert : Modelo.ClassOperationBD.Operacao.Update, 1);
        }

        /// <summary>
        /// método que insere ou atualiza dados no banco em massa, nesta sobrecarga é possível definir quantas vezes será feito o processo.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Lista"></param>
        /// <param name="IsInsert"></param>
        /// <returns></returns>
        public bool Save<T>(List<T> Lista, Boolean IsInsert, int executarXVezes) where T : new()
        {
            return SqlOperationBD.Commit(Lista, IsInsert ? Modelo.ClassOperationBD.Operacao.Insert : Modelo.ClassOperationBD.Operacao.Update, executarXVezes);
        }

        /// <summary>
        /// Método para exclusão de dados no banco
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Obj"></param>
        public void Delete<T>(T Obj) where T : new()
        {
            List<T> ListaObj = new List<T> { Obj };
            SqlOperationBD.Commit<T>(ListaObj, Modelo.ClassOperationBD.Operacao.Delete, 1);
        }

        /// <summary>
        /// Valida erros de acordo com a modelagem da classe de dados.
        /// </summary>
        /// <param name="obj"></param>
        private void ValidationErros(object obj)
        {
            var resultadoValidacao = new List<ValidationResult>();
            var contexto = new ValidationContext(obj, null, null);
            Validator.TryValidateObject(obj, contexto, resultadoValidacao, true);
            if (resultadoValidacao.Count() > 0)
            {
                string ErroMessage = String.Empty;
                for (int i = 0; i <= resultadoValidacao.Count() - 1; i++)
                    ErroMessage += "\n=========ERRO " + (i + 1).ToString() + "================\n" + resultadoValidacao[i].ToString();

                throw new ApplicationException(ErroMessage);
            }
        }

    }
}
