using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Cadastro.Data
{
    public class CadastroDbContextFactory : IDesignTimeDbContextFactory<CadastroDbContext>
    {
        public CadastroDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CadastroDbContext>();
            optionsBuilder.UseSqlServer("DataBase");

            return new CadastroDbContext(optionsBuilder.Options);
        }
    }
}
