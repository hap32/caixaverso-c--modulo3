using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Domain.Entitites
{
    public class ItemPedido
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Subtotal() => Produto.Preco * Quantidade;

    }
}
