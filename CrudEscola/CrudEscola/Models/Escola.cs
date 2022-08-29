using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudEscola.Models
{

    [Table("Escola")]   
    public class Escola
    {
        [Column("Id_Escola")]
        [Display(Name = "Código Escola")]
        public int Id { get; set; }

        [Column("Nome_Escola")]
        [Display(Name = "Nome da Escola")]
        public string NomeEscola { get; set; }
    }
}
