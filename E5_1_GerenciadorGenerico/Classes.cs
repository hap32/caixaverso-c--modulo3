using System;
using System.Collections.Generic;
using System.Linq;

public class Gerenciador<T>
{
    private readonly List<T> _itens = new();

    public void Adicionar(T item)
    {
        _itens.Add(item);
    }

    public List<T> ObterTodos()
    {
        return new List<T>(_itens);
    }

    public List<T> Filtrar(Func<T, bool> criterio)
    {
        return _itens.Where(criterio).ToList();
    }
}

public class Aluno
{
    public string? Nome { get; set; }
    public double NotaFinal { get; set; }
}

public class Produto
{
    public string? Nome { get; set; }
    public decimal Preco { get; set; }
}
