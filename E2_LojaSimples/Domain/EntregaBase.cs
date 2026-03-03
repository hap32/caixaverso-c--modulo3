using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaSimples.Domain
{
    public abstract class EntregaBase

    {
        public string endereco { get; set; }
        public EntregaBase(string endereco) 
        {
            this.endereco = endereco;
        }

        public abstract decimal CalcularFrete(decimal totalDoCarrinho);
    }
}
