using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain.Entities;

namespace Projeto.Infrastructure.Configuration;

public class DesenvolvedoraConfiguration : IEntityTypeConfiguration<Desenvolvedora>
{
    public void Configure(EntityTypeBuilder<Desenvolvedora> builder)
    {
        builder.HasKey(d => d.DesenvolvedoraId);

        builder.Property(d => d.Nome)
            .IsRequired()
            .HasMaxLength(150);

        builder.HasMany(d => d.Jogos)
            .WithOne(j => j.Desenvolvedora)
            .HasForeignKey(j => j.DesenvolvedoraId);
    }
}