using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain.Entities;

namespace Projeto.Infrastructure.Configuration;

public class BibliotecaConfiguration : IEntityTypeConfiguration<Biblioteca>
{
    public void Configure(EntityTypeBuilder<Biblioteca> builder)
    {
        builder.HasKey(b => b.BibliotecaId);

        builder.Property(b => b.DataCompra)
            .IsRequired();

        builder.Property(b => b.HorasJogadas)
            .IsRequired();

        builder.HasOne(b => b.Usuario)
            .WithMany(u => u.Bibliotecas)
            .HasForeignKey(b => b.UsuarioId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(b => b.Jogo)
            .WithMany(j => j.Bibliotecas)
            .HasForeignKey(b => b.JogoId)
            .OnDelete(DeleteBehavior.Cascade);

      
        builder.HasIndex(b => new { b.UsuarioId, b.JogoId })
            .IsUnique();
    }
}