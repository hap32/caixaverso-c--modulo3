using E7_1_CheckoutEcommerce.Interfaces;
using E7_1_CheckoutEcommerce.Models;
using E7_1_CheckoutEcommerce.Services;
using E7_1_CheckoutEcommerce.Services.Pagamentos;

class Program
{
    static void Main()
    {
        var carrinho = new CarrinhoDeCompras();
        var comprovante = new Comprovante();

        carrinho.AdicionarProduto("Notebook", 3500.00m, 1);
        carrinho.AdicionarProduto("Mouse", 150.00m, 2);

        IPagamento formaEscolhida = new PagamentoPix();
        carrinho.FinalizarCompra(formaEscolhida, comprovante); 
    }
}