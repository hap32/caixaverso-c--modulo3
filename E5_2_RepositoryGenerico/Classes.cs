using System;
using System.Collections.Generic;
using System.Linq;

public interface IEntidade
{
    int Id { get; set; }
}

public class Cliente : IEntidade
{
    public int Id { get; set; }
    public string? Nome { get; set; }
}

public class Pedido : IEntidade
{
    public int Id { get; set; }
    public string? Descricao { get; set; }
}

public class Repository<T> where T : IEntidade
{
    private readonly List<T> _entidades = new();

    public void Adicionar(T entidade)
    {
        _entidades.Add(entidade);
    }

    public T? ObterPorId(int id)
    {
        return _entidades.FirstOrDefault(e => e.Id == id);
    }

    public List<T> ObterTodos()
    {
        return new List<T>(_entidades);
    }

    public void Remover(int id)
    {
        var entidade = ObterPorId(id);
        if (entidade != null)
            _entidades.Remove(entidade);
    }
}
