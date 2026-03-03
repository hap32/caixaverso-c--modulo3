// See https://aka.ms/new-console-template for more information
using NFSimplic.Domain;
using NFSimplic.Services;


//Separar em pastas Domain, Services

var arroz = new Produto(1, "Arroz", 15m, CategoriaProduto.Alimento);
var mouse = new Produto(2, "Mouse", 79.90m, CategoriaProduto.Eletronico);
var servico = new Produto(3, "Serviço de instalação", 80m, CategoriaProduto.Servico);

var nota = new NotaFiscal();

nota.AdicionarItem(mouse, 2);
nota.AdicionarItem(arroz, 3);
nota.AdicionarItem(servico, 1);

nota.ExibirResumo();

var impostos = new List<ImpostoBase>
{
    new ImpostoAlimento(),
    new ImpostoEletronico(),
    new ImpostoServico()
};

var calculadora = new CalculadoraImpostos();

var totalImpostos = calculadora.CalcularTotalImpostos(nota, impostos);
var totalFinal = nota.TotalBruto() + totalImpostos;

Console.WriteLine($"Impostos: {totalImpostos:C}");
Console.WriteLine($"Total final: {totalFinal:C}");
Console.WriteLine("==================");
