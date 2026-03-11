using System;

namespace Projeto.Api.Domain.Entities;

public class Biblioteca
{
    public int BibliotecaId { get; set; }
    public int UsuarioId { get; set; }
    public int JogoId { get; set; }
    public DateTime DataCompra { get; set; }
    public int HorasJogadas { get; set; }
    
    public Usuario Usuario { get; set; }

    public Jogo Jogo { get; set; }
    
}