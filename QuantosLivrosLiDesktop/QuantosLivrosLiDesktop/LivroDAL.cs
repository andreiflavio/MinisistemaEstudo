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
    public class LivroDAL : DAL
    {
        [Key]
        [DisplayName("ID")]
        [Column(Name = "ID", IsPrimaryKey = true)]
        public Int64 idLivro { get; set; }

        [DisplayName("Nome")]
        [Column]
        [Required(ErrorMessage = "Digite o nome do livro.")]
        public string nome { get; set; }

        [DisplayName("Comecei em")]
        [Column]
        [Required(ErrorMessage = "Digite a data em que começou leitura do livro.")]
        public DateTime dt_inicio { get; set; }

        [DisplayName("Terminei em")]
        [Column]
        public DateTime dt_final { get; set; }

        [DisplayName("Observações")]
        [Column]
        public string obs { get; set; }

        [DisplayName("Série")]
        [Column]
        public Int64 idSerie { get; set; }

        [DisplayName("Autor")]
        [Column]
        public Int64 idAutor { get; set; }

        public override string getTableName()
        {
            return "Livro";
        }
    }
}
