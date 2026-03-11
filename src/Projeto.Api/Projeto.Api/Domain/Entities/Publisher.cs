using System.Collections.Generic;
namespace Projeto.Api.Domain.Entities;

public class Publisher
{
    public int PublisherId { get; set; }
    public string Nome { get; set; }
    public string Pais { get; set; }
    public ICollection<Jogo> Jogos { get; set; }

}