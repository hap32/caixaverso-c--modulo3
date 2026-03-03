using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LojaSimples.Domain
{
    public class EntregaNormal : EntregaBase
    {
        public EntregaNormal(string endereco) : base(endereco) { }

        public override decimal CalcularFrete(decimal totalDoCarrinho)
        {
            var frete = totalDoCarrinho * 0.10m;
            return frete < 15m ? 15m : frete;
        }
        

    }
}
