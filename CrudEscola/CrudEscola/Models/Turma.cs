using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CrudEscola.Models
{

    [Table("Turma")]
    public class Turma
    {
        [Column("Id_Turma")]
        [Display(Name = "Código Turma")]
        public int Id { get; set; }

        [Column("Nome_Turma")]
        [Display(Name = "Nome da Turma")]
        public string NomeTurma { get; set; }

        [Column("Sala_Turma")]
        [Display(Name = "Sala")]
        public string SalaTurma { get; set; }

    }
}