using ProjetoFinal.Domain.Interfaces;

namespace ProjetoFinal.Domain.Services
{
    public class PagamentoCartao : IPagamento
    {
        public string Nome => "Cartão de Crédito";

        public void Pagar(decimal valor) => Console.WriteLine($"Pagamento via Cartão de Crédito de {valor:C2}.");
        
    }
}