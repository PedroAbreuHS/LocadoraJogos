using LocadoraJogos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraJogos.Infrastructure.Data.Mappings
{
    public class AluguelMapping : IEntityTypeConfiguration<Aluguel>
    {
        public void Configure(EntityTypeBuilder<Aluguel> builder)
        {
            builder.ToTable("Alugueis");

            builder.HasKey(a => a.Id);

            builder.HasOne(a => a.Cliente)
                .WithMany(c => c.Alugueis)
                .HasForeignKey(a => a.IdCliente)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.Jogo)
                .WithMany(j => j.Alugueis)
                .HasForeignKey(a => a.IdJogo)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(a => a.DataEmprestimo)
                .IsRequired();

            builder.Property(a => a.DataDevolucaoPrevista)
                .IsRequired();
        }
    }
}
