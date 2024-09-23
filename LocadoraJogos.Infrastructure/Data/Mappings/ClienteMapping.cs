using LocadoraJogos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraJogos.Infrastructure.Data.Mappings
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(150);

            builder.Property(c => c.Email)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(100);

            builder.OwnsOne(c => c.Endereco, e =>
            {
                e.Property(e => e.Rua).HasColumnName("Rua");
                e.Property(e => e.NumeroCasa).HasColumnName("Numero_Casa");
                e.Property(e => e.CEP).HasColumnName("CEP");
                e.Property(e => e.Bairro).HasColumnName("Bairro");
                e.Property(e => e.Cidade).HasColumnName("Cidade");
                e.Property(e => e.Estado).HasColumnName("Estado");
            });
                

            builder.Property(c => c.DataDeAniversario)
                .IsRequired();
        }
    }
}
