using E7_1_CheckoutEcommerce.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7_1_CheckoutEcommerce.Services.Pagamentos
{
    public class PagamentoDebito : IPagamento
    {
        public string Nome => "DÉBITO";
        public void Pagar(decimal valor)
        {
            Console.WriteLine($"Pagamento de R${valor:F2} realizado via DÉBITO.");
        }
    }
}
