using Cadastro.Models;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.Data
{
    public class CadastroDbContext : DbContext
    {

        public CadastroDbContext(DbContextOptions<CadastroDbContext> options) 
            : base(options) 
        {
        }

        public DbSet<UsuarioModel> Usuario { get; set; }
        public DbSet<PessoaFisicaModel> PessoaFisica { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
