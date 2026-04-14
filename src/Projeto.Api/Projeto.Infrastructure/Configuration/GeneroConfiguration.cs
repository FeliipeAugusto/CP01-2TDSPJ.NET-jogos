using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain.Entities;

namespace Projeto.Infrastructure.Configurations;

public class GeneroConfiguration : IEntityTypeConfiguration<Genero>
{
    public void Configure(EntityTypeBuilder<Genero> builder)
    {
        builder.HasKey(g => g.GeneroId);

        builder.Property(g => g.Nome)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasMany(g => g.Jogos)
            .WithOne(j => j.Genero)
            .HasForeignKey(j => j.GeneroId);
    }
}