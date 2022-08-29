using Microsoft.EntityFrameworkCore;

namespace CrudEscola.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options):base(options)
        {


        }

        public DbSet<Escola> escola { get; set; }
        public DbSet<Turma> turma { get; set; }
        public DbSet<Aluno> aluno { get; set; }

    }
}
