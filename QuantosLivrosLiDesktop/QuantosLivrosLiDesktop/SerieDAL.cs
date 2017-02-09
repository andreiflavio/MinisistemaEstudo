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
    public class SerieDAL : DAL
    {
        [Key]
        [DisplayName("ID")]
        [Column(Name = "ID", IsPrimaryKey = true)]
        public Int64 idSerie { get; set; }

        [DisplayName("Nome")]
        [Column]
        [Required(ErrorMessage = "Digite o nome da série.")]
        public string nome { get; set; }

        [DisplayName("Status")]
        [Column]
        public Int64 status { get; set; }

        public override string getTableName()
        {
            return "Série";
        }
    }
}
