using LojaSimples.Domain;
using LojaSimples.Dominio;

class Program
{
    static void Main()
    {
        Console.WriteLine("Loja Simples - Teste de Carrinho e Entrega");
        var produto1 = new Produto(1, "Camiseta", 50m);
        var produto2 = new Produto(2, "Calça", 120m);

        var carrinho = new Carrinho();
        carrinho.Adicionar(produto1, 2);
        carrinho.Adicionar(produto2);
        carrinho.Adicionar(produto1); //deve somar a quantidade

        carrinho.ExibirResumo();

        EntregaBase entrega = new EntregaExpressa("Rua X, 123");

        var frete = entrega.CalcularFrete(carrinho.Total());

        Console.WriteLine($"Frete: R$ {frete:F2}");
        Console.WriteLine($"Total com frete: R$ {(carrinho.Total() + frete):F2}");
    }
}
