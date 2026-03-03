using System;
using System.ComponentModel.DataAnnotations;

public enum AnoEscolar
{
    [Display(Name = "sétimo")]
    Setimo = 7,

    [Display(Name = "oitavo")]
    Oitavo = 8
}

public class Endereco
{
    public string? Rua { get; set; }
    public int Numero { get; set; }
}

public class Aluno
{
    public string? Nome { get; set; }
    public AnoEscolar Ano { get; set; }
    public DateTime DataNascimento { get; set; }

    [Ocultar]
    public string? Documento { get; set; }

    public Endereco? Endereco { get; set; }
}
