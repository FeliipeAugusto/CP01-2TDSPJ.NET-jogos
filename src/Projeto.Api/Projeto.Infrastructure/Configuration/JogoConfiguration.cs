using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain.Entities;

namespace Projeto.Infrastructure.Configuration;
public class JogoConfiguration : IEntityTypeConfiguration<Jogo>
{
    public void Configure(EntityTypeBuilder<Jogo> builder)
    {
        builder.HasKey(j => j.JogoId);

        builder.Property(j => j.Titulo).IsRequired().HasMaxLength(150);
        builder.Property(j => j.Preco).HasColumnType("decimal(10,2)");

        builder.HasOne(j => j.Genero)
            .WithMany(g => g.Jogos)
            .HasForeignKey(j => j.GeneroId);

        builder.HasOne(j => j.Desenvolvedora)
            .WithMany(d => d.Jogos)
            .HasForeignKey(j => j.DesenvolvedoraId);

        builder.HasOne(j => j.Publisher)
            .WithMany(p => p.Jogos)
            .HasForeignKey(j => j.PublisherId);
    }
}