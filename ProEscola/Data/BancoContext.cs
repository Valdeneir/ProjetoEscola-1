using Microsoft.EntityFrameworkCore;
using ProEscola.Models;

namespace ProEscola.Data
{
    public class BancoContext : DbContext
    {

        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {


        }

        public DbSet<AlunoModel> Aluno { get; set; } /* Conectando com a Tabela  Aluno*/

    }
}