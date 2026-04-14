using Microsoft.EntityFrameworkCore;
using Projeto.Domain.Entities;
using Projeto.Application.Interfaces;
using Projeto.Infrastructure.Data;

public class BibliotecaRepository : IBibliotecaRepository
{
    private readonly AppDbContext _context;

    public BibliotecaRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Biblioteca>> GetAllAsync()
    {
        return await _context.Bibliotecas
            .Include(b => b.Usuario)
            .Include(b => b.Jogo)
            .ToListAsync();
    }

    public async Task AddAsync(Biblioteca biblioteca)
    {
        await _context.Bibliotecas.AddAsync(biblioteca);
        await _context.SaveChangesAsync();
    }
}