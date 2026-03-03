using System;

class Program
{
    static void Main()
    {
        var gerenciadorAlunos = new Gerenciador<Aluno>();

        gerenciadorAlunos.Adicionar(new Aluno { Nome = "Ana", NotaFinal = 8.5 });
        gerenciadorAlunos.Adicionar(new Aluno { Nome = "Bruno", NotaFinal = 6.0 });
        gerenciadorAlunos.Adicionar(new Aluno { Nome = "Carlos", NotaFinal = 9.0 });

        var aprovados = gerenciadorAlunos.Filtrar(a => a.NotaFinal > 7);

        Console.WriteLine("Alunos com nota maior que 7:");
        foreach (var aluno in aprovados)
            Console.WriteLine($"{aluno.Nome} - {aluno.NotaFinal}");

        Console.WriteLine("\n-----------------------\n");

        var gerenciadorProdutos = new Gerenciador<Produto>();

        gerenciadorProdutos.Adicionar(new Produto { Nome = "Teclado", Preco = 150 });
        gerenciadorProdutos.Adicionar(new Produto { Nome = "Mouse", Preco = 80 });
        gerenciadorProdutos.Adicionar(new Produto { Nome = "Monitor", Preco = 1200 });

        var caros = gerenciadorProdutos.Filtrar(p => p.Preco > 100);

        Console.WriteLine("Produtos com preço maior que 100:");
        foreach (var produto in caros)
            Console.WriteLine($"{produto.Nome} - {produto.Preco}");
    }
}
