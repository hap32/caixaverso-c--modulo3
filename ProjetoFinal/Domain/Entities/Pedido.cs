using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Domain.Entitites
{
    public class Pedido
    {
        private readonly List<ItemPedido> _itens = new();
        public IReadOnlyCollection<ItemPedido> Itens => _itens.AsReadOnly();

        public void AdicionarItem(Produto produto, int quantidade)
        {
            if (quantidade < 1) return;
            _itens.Add(new ItemPedido { Produto = produto, Quantidade = quantidade });
        }

        public decimal TotalBruto() => _itens.Sum(i => i.Subtotal());
    }
}
