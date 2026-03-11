using System;
using System.Collections.Generic;
namespace Projeto.Api.Domain.Entities;

public class Desenvolvedora
{
    public int DesenvolvedoraId { get; set; }
    public string Nome { get; set; }
    public string Pais { get; set; }
    public DateTime AnoFundacao { get; set; }
    public ICollection<Jogo> Jogos { get; set; }

}