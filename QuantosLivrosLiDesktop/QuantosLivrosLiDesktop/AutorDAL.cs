using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantosLivrosLiDesktop
{
    public class AutorDAL : DAL
    {
        [Key]
        [DisplayName("ID")]
        [Column(Name = "ID", IsPrimaryKey = true)]
        public Int64 idAutor { get; set; }

        [DisplayName("Nome")]
        [Column]
        [Required(ErrorMessage = "Digite o nome do autor.")]
        public string nome { get; set; }

        public override string getTableName()
        {
            return "Autor";
        }
    }
}
