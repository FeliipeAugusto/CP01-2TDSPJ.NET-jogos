using System;
using System.Collections.Generic;

namespace Projeto.Domain.Entities;

public class Jogo
{
    public int JogoId { get; set; }
    public string Titulo { get; set; }
    public decimal Preco { get; set; }
    public DateTime DataLancamento { get; set; }

    public int GeneroId { get; set; }
    public int DesenvolvedoraId { get; set; }
    public int PublisherId { get; set; }

    public Genero Genero { get; set; }
    public Desenvolvedora Desenvolvedora { get; set; }
    public Publisher Publisher { get; set; }

    public ICollection<Conquista> Conquistas { get; set; } = new List<Conquista>();
    public ICollection<Biblioteca> Bibliotecas { get; set; } = new List<Biblioteca>();
}