using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain.Entities;

namespace Projeto.Infrastructure.Configurations;

public class JogoConfiguration : IEntityTypeConfiguration<Jogo>
{
    public void Configure(EntityTypeBuilder<Jogo> builder)
    {
        builder.HasKey(j => j.JogoId);

        builder.Property(j => j.Titulo)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(j => j.Preco)
            .HasColumnType("decimal(10,2)");

        builder.Property(j => j.DataLancamento)
            .IsRequired();

        builder.HasOne(j => j.Genero)
            .WithMany(g => g.Jogos)
            .HasForeignKey(j => j.GeneroId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(j => j.Desenvolvedora)
            .WithMany(d => d.Jogos)
            .HasForeignKey(j => j.DesenvolvedoraId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(j => j.Publisher)
            .WithMany(p => p.Jogos)
            .HasForeignKey(j => j.PublisherId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(j => j.Conquistas)
            .WithOne(c => c.Jogo)
            .HasForeignKey(c => c.JogoId);

        builder.HasMany(j => j.Bibliotecas)
            .WithOne(b => b.Jogo)
            .HasForeignKey(b => b.JogoId);

        builder.HasIndex(j => j.Titulo);
    }
}