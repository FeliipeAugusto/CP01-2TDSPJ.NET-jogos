using System.Collections.Generic;

namespace Projeto.Domain.Entities;

public class Desenvolvedora
{
    public int DesenvolvedoraId { get; set; }
    public string Nome { get; set; }

    public ICollection<Jogo> Jogos { get; set; } = new List<Jogo>();
}