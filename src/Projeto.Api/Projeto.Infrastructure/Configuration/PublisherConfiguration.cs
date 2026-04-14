using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain.Entities;

namespace Projeto.Infrastructure.Configurations;

public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
{
    public void Configure(EntityTypeBuilder<Publisher> builder)
    {
        builder.HasKey(p => p.PublisherId);

        builder.Property(p => p.Nome)
            .IsRequired()
            .HasMaxLength(150);

        builder.HasMany(p => p.Jogos)
            .WithOne(j => j.Publisher)
            .HasForeignKey(j => j.PublisherId);
    }
}