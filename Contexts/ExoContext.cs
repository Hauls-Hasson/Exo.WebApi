using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL; // Adicione esta linha

namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext()
        {
        }

        public ExoContext(DbContextOptions<ExoContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Configuração da string de conexão para PostgreSQL no ElephantSQL
                optionsBuilder.UseNpgsql("postgres://aljsjkqg:DumaalbNdbBjTgfHvsm0UjAqZ0tOBMEr@motty.db.elephantsql.com/aljsjkqg");
            }
        }

        public DbSet<Projeto> Projetos { get; set; }
    }
}
