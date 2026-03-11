namespace Projeto.Api.Domain.Entities;

public class Conquista
{
    public int ConquistaId { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int JogoId { get; set; }
    public Jogo Jogo { get; set; }

}