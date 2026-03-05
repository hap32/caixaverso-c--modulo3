using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7_1_CheckoutEcommerce.Services
{
    public class Comprovante
    {
        public void Gerar(decimal valorTotal)
        {
            Console.WriteLine($"Comprovante: compra no valor de R$ {valorTotal:F2}");
        }
    }
}
