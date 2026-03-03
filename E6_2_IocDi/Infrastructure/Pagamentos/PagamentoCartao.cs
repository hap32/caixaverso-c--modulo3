using ioc_di.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioc_di.Infrastructure.Pagamentos
{
    public class PagamentoCartao : IPagamento
    {
        public string Nome => "Cartão";

        public void Pagar(decimal valor)
        {
            Console.WriteLine($"Pagamento de {valor:C} realizado via Cartão.");
        }
    }
}
