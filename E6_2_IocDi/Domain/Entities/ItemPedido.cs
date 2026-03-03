using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioc_di.Domain.Entities
{
    public class ItemPedido
    {
        public Produto Produto { get; }
        public int Quantidade { get; }

        public ItemPedido(Produto produto, int quantidade)
        {
            if (quantidade < 1)
                throw new ArgumentException("Quantidade deve ser pelo menos 1.");

            Produto = produto ?? throw new ArgumentNullException(nameof(produto));
            Quantidade = quantidade;
        }

        public decimal Subtotal()
        {
            return Produto.Preco * Quantidade;
        }
    }
}
