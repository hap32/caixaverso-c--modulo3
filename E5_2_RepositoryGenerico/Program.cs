using System;

class Program
{
    static void Main()
    {
        var repoClientes = new Repository<Cliente>();

        repoClientes.Adicionar(new Cliente { Id = 1, Nome = "João" });
        repoClientes.Adicionar(new Cliente { Id = 2, Nome = "Maria" });
        repoClientes.Adicionar(new Cliente { Id = 3, Nome = "Carlos" });

        var cliente = repoClientes.ObterPorId(2);
        Console.WriteLine($"Cliente encontrado: {cliente?.Nome}");

        repoClientes.Remover(1);

        Console.WriteLine("Clientes restantes:");
        foreach (var c in repoClientes.ObterTodos())
            Console.WriteLine($"{c.Id} - {c.Nome}");

        Console.WriteLine("\n-----------------------\n");

        var repoPedidos = new Repository<Pedido>();

        repoPedidos.Adicionar(new Pedido { Id = 1, Descricao = "Pedido A" });
        repoPedidos.Adicionar(new Pedido { Id = 2, Descricao = "Pedido B" });
        repoPedidos.Adicionar(new Pedido { Id = 3, Descricao = "Pedido C" });

        var pedido = repoPedidos.ObterPorId(3);
        Console.WriteLine($"Pedido encontrado: {pedido?.Descricao}");

        repoPedidos.Remover(2);

        Console.WriteLine("Pedidos restantes:");
        foreach (var p in repoPedidos.ObterTodos())
            Console.WriteLine($"{p.Id} - {p.Descricao}");
    }
}
