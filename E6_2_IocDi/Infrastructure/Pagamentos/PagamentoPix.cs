using ioc_di.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioc_di.Infrastructure.Pagamentos
{
    public class PagamentoPix : IPagamento
    {
        public string Nome => "PIX";

        public void Pagar(decimal valor)
        {
            Console.WriteLine($"Pagamento de {valor:C} realizado via PIX.");
        }
    }
}
