using LocadoraJogos.Domain.Entities;
using LocadoraJogos.Domain.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraJogos.Infrastructure.Data.Mappings
{
    public class JogoMapping : IEntityTypeConfiguration<Jogo>
    {
        public void Configure(EntityTypeBuilder<Jogo> builder)
        {
            builder.ToTable("Jogos");

            builder.HasKey(j => j.Id);

            builder.Property(j => j.Nome)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(150);

            builder.Property(j => j.Genero)                                 //configurando o enum para ser armazenado como string
                .IsRequired()
                .HasConversion(
                    s => s.ToString(),                                      //converter o enum para string ao salvar no banco
                    s => (GeneroJogo)Enum.Parse(typeof(GeneroJogo), s));    //converter a string de vola para enum ao ler do banco

            builder.Property(j => j.AnoLancamento)
                .IsRequired();
                
        }
    }
}
