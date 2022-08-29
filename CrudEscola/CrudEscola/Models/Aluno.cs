using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
namespace CrudEscola.Models
{

    [Table("Aluno")]
    public class Aluno
    {
        [Column("Id_Aluno")]
        [Display(Name = "Código Aluno")]
        public int Id { get; set; }

        [Column("Nome_Aluno")]
        [Display(Name = "Nome do Aluno")]
        public string NomeAluno { get; set; }

        [Column("Idade_Aluno")]
        [Display(Name = "Idade do Aluno")]
        public int IdadeAluno { get; set; }

        [Column("Id_Turma")]
        [Display(Name = "Turma")]
        public int Id_Turma { get; set; }

    }
}