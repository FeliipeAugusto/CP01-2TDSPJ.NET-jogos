using Projeto.Domain.Entities;

namespace Projeto.Application.Interfaces;

public interface IBibliotecaRepository
{
    Task<IEnumerable<Biblioteca>> GetAllAsync();
    Task AddAsync(Biblioteca biblioteca);
}