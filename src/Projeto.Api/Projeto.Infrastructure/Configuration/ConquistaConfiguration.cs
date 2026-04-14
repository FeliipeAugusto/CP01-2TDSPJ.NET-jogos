using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain.Entities;

namespace Projeto.Infrastructure.Configuration;

public class ConquistaConfiguration : IEntityTypeConfiguration<Conquista>
{
    public void Configure(EntityTypeBuilder<Conquista> builder)
    {
        builder.HasKey(c => c.ConquistaId);

        builder.Property(c => c.Nome)
            .IsRequired()
            .HasMaxLength(150);

        builder.HasOne(c => c.Jogo)
            .WithMany(j => j.Conquistas)
            .HasForeignKey(c => c.JogoId);
    }
}