using Microsoft.Extensions.DependencyInjection;
using ProjetoFinal.Application;
using ProjetoFinal.Domain.Entitites;
using ProjetoFinal.Domain.Interfaces;
using ProjetoFinal.Domain.Services;
using ProjetoFinal.Infrastructure.Logging;

var services = new ServiceCollection();

services.AddSingleton<ILogger, ConsoleLogger>();
services.AddSingleton<IDesconto>(new DescontoPercentual(10));
services.AddSingleton<IDesconto>(new DescontoPorQuantidade());
//services.AddScoped<IPagamento, PagamentoPix>();
services.AddScoped<IPagamento, PagamentoCartao>();
services.AddScoped<PedidoProcessor>();

var serviceProvider = services.BuildServiceProvider();

var mouse = new Produto { Id = 1, Nome = "Mouse", Preco = 79.90m };
var teclado = new Produto { Id = 2, Nome = "Teclado", Preco = 159.90m };
var headset = new Produto { Id = 3, Nome = "Headset", Preco = 249.90m };

var pedido = new Pedido();
pedido.AdicionarItem(mouse, 2);
pedido.AdicionarItem(teclado, 1);
pedido.AdicionarItem(headset, 2);

var processor = serviceProvider.GetRequiredService<PedidoProcessor>();
processor.Processar(pedido);