using E7_2_MiniSistemaCadastro.Domain.Entities;
using E7_2_MiniSistemaCadastro.Infrastructure.Logging;
using E7_2_MiniSistemaCadastro.Infrastructure.Persistence;
using E7_2_MiniSistemaCadastro.Services;

var logger = new ConsoleLogger();
var repoProd = new ProdutoRepositorioComValidacao(); // LSP: trocável [cite: 125]
var repoNF = new NotaFiscalRepositorioEmMemoria();
var service = new CadastroService(repoProd, repoNF, logger); [cite: 110]

// 2 produtos válidos e 1 inválido
service.CadastrarProduto(new Produto { Id = Guid.NewGuid(), Descricao = "Teclado Mechanical", ValorUnitario = 200 });
service.CadastrarProduto(new Produto { Id = Guid.NewGuid(), Descricao = "Mouse Gamer", ValorUnitario = 150 });
service.CadastrarProduto(new Produto { Id = Guid.NewGuid(), Descricao = "" }); // Vai cair no catch do service

// Listar ao final
foreach (var p in repoProd.Listar()) Console.WriteLine($"- {p.Descricao}");