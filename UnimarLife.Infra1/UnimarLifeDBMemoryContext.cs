using Microsoft.EntityFrameworkCore;
using UnimarLife.Domain.AdministradorContext;
using UnimarLife.Domain.PersonaContext;

namespace UnimarLife.Infra.MemoryDb
{

    public class UnimarLifeDBMemoryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "UnimarLifeDb");

        }

        public DbSet<Administrador>? Administradores { get; set; }
        public DbSet<Usuario>? Usuarios { get; set; } 
        public DbSet<Academico>? Academicos { get; set; }
    }
}