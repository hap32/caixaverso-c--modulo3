using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFSimplic.Domain
{
    public class ItemNotaFiscal
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }

        public ItemNotaFiscal(Produto produto, int quantidade) {
            if (quantidade <= 0)
                throw new ArgumentException("Quantidade deve ser maior que zero.");

            Produto = produto;
            Quantidade = quantidade;
        }

        public decimal Subtotal()
        {
            return Produto.Preco * Quantidade;
        }
    }
}
