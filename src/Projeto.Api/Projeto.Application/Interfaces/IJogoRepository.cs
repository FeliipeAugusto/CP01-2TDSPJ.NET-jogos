using Projeto.Domain.Entities;

namespace Projeto.Application.Interfaces;

public interface IJogoRepository
{
    Task<IEnumerable<Jogo>> GetAllAsync();
    Task<Jogo> GetByIdAsync(int id);
    Task AddAsync(Jogo jogo);
}