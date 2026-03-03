using LojaSimples.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaSimples.Domain
{
    public class Carrinho
    {
        private readonly List<ItemCarrinho> itens = new();

        public void Adicionar(Produto produto) {
            Adicionar(produto, 1);
        }

        public void Adicionar(Produto produto, int quantidade)
        {
            foreach (var item in itens) 
                if (item.produto.id == produto.id)  
                    item.quantidade = quantidade;
                  
            itens.Add(new ItemCarrinho(produto, quantidade));
        }

        public void Remover(int idProduto) 
        {
            var item = itens[idProduto];
            itens.Remove(item);
        }

        public decimal Total() 
        {
            decimal total = 0;

            foreach (var item in itens)
                total += item.Subtotal();

            return total;
        }

        public void ExibirResumo() 
        {
            Console.WriteLine("Resumo do Carrinho:");
            foreach (var item in itens)
                Console.WriteLine($"{item.produto.nome} | Qtd: {item.quantidade} | Subtotal: {item.Subtotal():F2}");

            Console.WriteLine($"Total: R$ {Total():F2}");
        }
    }
}