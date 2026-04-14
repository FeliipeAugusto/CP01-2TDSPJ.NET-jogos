using Microsoft.EntityFrameworkCore;
using Projeto.Domain.Entities;
using Projeto.Infrastructure.Configuration;

namespace Projeto.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Jogo> Jogos { get; set; }
    public DbSet<Biblioteca> Bibliotecas { get; set; }
    public DbSet<Genero> Generos { get; set; }
    public DbSet<Desenvolvedora> Desenvolvedoras { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<Conquista> Conquistas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
        modelBuilder.ApplyConfiguration(new JogoConfiguration());
        modelBuilder.ApplyConfiguration(new BibliotecaConfiguration());
        modelBuilder.ApplyConfiguration(new GeneroConfiguration());
        modelBuilder.ApplyConfiguration(new DesenvolvedoraConfiguration());
        modelBuilder.ApplyConfiguration(new PublisherConfiguration());
        modelBuilder.ApplyConfiguration(new ConquistaConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}