using System.Collections.Generic;

namespace Projeto.Domain.Entities;

public class Publisher
{
    public int PublisherId { get; set; }
    public string Nome { get; set; }

    public ICollection<Jogo> Jogos { get; set; } = new List<Jogo>();
}