using System;
using System.Collections.Generic;

namespace Projeto.Domain.Entities;

public class Usuario
{
    public int UsuarioId { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Pais { get; set; }
    public DateTime DataCadastro { get; set; }

    public ICollection<Biblioteca> Bibliotecas { get; set; } = new List<Biblioteca>();
}