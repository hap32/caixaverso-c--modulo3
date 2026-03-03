using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaSimples.Domain
{
    public class EntregaExpressa : EntregaBase
    {
        public EntregaExpressa(string endereco) : base(endereco) { }

        public override decimal CalcularFrete(decimal totalDoCarrinho)
        {
            var frete = totalDoCarrinho * 0.20m;
            return frete < 30m ? 30m : frete;
        }
    }
}
