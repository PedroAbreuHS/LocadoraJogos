using LocadoraJogos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace LocadoraJogos.Infrastructure.Data.Contexts
{
    public class LocadoraJogosDbContext : DbContext
    {
        public LocadoraJogosDbContext(DbContextOptions<LocadoraJogosDbContext> options) : base(options)
        {
        }

        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Aluguel> Aluguels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
