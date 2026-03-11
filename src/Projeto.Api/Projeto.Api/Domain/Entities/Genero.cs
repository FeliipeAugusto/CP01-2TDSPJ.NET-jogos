using System.Collections.Generic;

namespace Projeto.Api.Domain.Entities;

public class Genero
{
    public int GeneroId {get; set;}
    public string Nome {get; set;}
    public ICollection<Jogo> Jogo { get; set; }
    
}