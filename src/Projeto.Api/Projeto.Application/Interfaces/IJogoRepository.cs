using Projeto.Domain.Entities;

public interface IJogoRepository
{
    Task<IEnumerable<Jogo>> GetAllAsync();
    Task<Jogo> GetByIdAsync(int id);
    Task AddAsync(Jogo jogo);
}