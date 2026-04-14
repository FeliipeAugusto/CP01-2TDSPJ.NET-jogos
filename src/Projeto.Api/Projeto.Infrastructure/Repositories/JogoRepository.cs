using Microsoft.EntityFrameworkCore;
using Projeto.Domain.Entities;
using Projeto.Application.Interfaces;
using Projeto.Infrastructure.Data;

namespace Projeto.Infrastructure.Repositories;
public class JogoRepository : IJogoRepository
{
    private readonly AppDbContext _context;

    public JogoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Jogo>> GetAllAsync()
    {
        return await _context.Jogos.ToListAsync();
    }

    public async Task<Jogo> GetByIdAsync(int id)
    {
        return await _context.Jogos.FindAsync(id);
    }

    public async Task AddAsync(Jogo jogo)
    {
        await _context.Jogos.AddAsync(jogo);
        await _context.SaveChangesAsync();
    }
}