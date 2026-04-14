using Projeto.Domain.Entities;

public interface IBibliotecaRepository
{
    Task<IEnumerable<Biblioteca>> GetAllAsync();
    Task AddAsync(Biblioteca biblioteca);
}