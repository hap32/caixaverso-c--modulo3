using ioc_di.Application.Services;
using ioc_di.Domain.Entities;
using ioc_di.Domain.Interfaces;
using ioc_di.Infrastructure.Logging;
using ioc_di.Infrastructure.Pagamentos;
using System.Xml.Serialization;
using Microsoft.Extensions.DependencyInjection;
using ioc_di.Application.Descontos;

class Program
{
    static void Main()
    {
        var services = new ServiceCollection();

        // Logger
        services.AddSingleton<ILogger, ConsoleLogger>();

        // Pagamento (troque aqui para Cartão se quiser)
        services.AddScoped<IPagamento, PagamentoPix>();
        // services.AddScoped<IPagamento, PagamentoCartao>();

        // Descontos (múltiplos registros!)
        services.AddScoped<IDesconto>(_ => new DescontoPercentual(0.10m));
        services.AddScoped<IDesconto>(_ => new DescontoPorQuantidade(5, 20m));

        // Processor
        services.AddScoped<PedidoProcessor>();

        var provider = services.BuildServiceProvider();

        var processor = provider.GetRequiredService<PedidoProcessor>();

        // Cenário
        var pedido = new Pedido();

        var produto1 = new Produto("Mouse", 100m);
        var produto2 = new Produto("Teclado", 200m);

        pedido.AdicionarItem(new ItemPedido(produto1, 3));
        pedido.AdicionarItem(new ItemPedido(produto2, 2));

        processor.Processar(pedido);
    }
}