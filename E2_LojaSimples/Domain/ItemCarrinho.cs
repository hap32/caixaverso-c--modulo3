using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LojaSimples.Dominio
{
    public class ItemCarrinho
    {
        public Produto produto { get; set; }
        public int quantidade { get; set; }
        
        public ItemCarrinho(Produto produto, int quantidade)
        {
            if (quantidade < 1) throw new ArgumentException("Quantidade inválida.");

            this.produto = produto;
            this.quantidade = quantidade;   
        }

        public decimal Subtotal() 
        {
            return produto.preco * quantidade;
        }
    }
}


