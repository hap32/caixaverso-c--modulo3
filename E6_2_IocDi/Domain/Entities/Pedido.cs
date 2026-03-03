using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioc_di.Domain.Entities
{
    public class Pedido
    {
        private readonly List<ItemPedido> _itens = new();

        public IReadOnlyCollection<ItemPedido> Itens => _itens.AsReadOnly();

        public void AdicionarItem(ItemPedido item)
        {
            _itens.Add(item);
        }

        public decimal TotalBruto()
        {
            return _itens.Sum(i => i.Subtotal());
        }

        public int TotalItens()
        {
            return _itens.Sum(i => i.Quantidade);
        }
    }
}
