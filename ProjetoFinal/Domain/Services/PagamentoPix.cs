using ProjetoFinal.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Domain.Services
{
    public class PagamentoPix : IPagamento
    {
        public string Nome => "Pix";
        public void Pagar(decimal valor) => Console.WriteLine($"Pagamento via Pix de {valor:F2}...");
    }
}
