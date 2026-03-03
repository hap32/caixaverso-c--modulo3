using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFSimplic.Domain
{
    internal class NotaFiscal
    {
        private readonly List<ItemNotaFiscal> itens = new();
        public IReadOnlyCollection<ItemNotaFiscal> Itens => itens.AsReadOnly();

        public void AdicionarItem(Produto produto, int quantidade)
        { 
            if(produto == null)
                throw new ArgumentNullException(nameof(produto), "Produto não pode ser nulo.");
        
            var itemExistente = itens.FirstOrDefault(i => i.Produto.Id == produto.Id);

            if (itemExistente != null)
            {
                itens.Remove(itemExistente);
                quantidade += itemExistente.Quantidade;
            }

            itens.Add(new ItemNotaFiscal(produto, quantidade));
        }

        public decimal TotalBruto()
        {
            return itens.Sum(i => i.Subtotal());
        }

        public void ExibirResumo()
        {
            Console.WriteLine("=== Resumo da Nota Fiscal ===");
            foreach (var item in itens)
            {
                Console.WriteLine($"{item.Produto.Nome} - Quantidade: {item.Quantidade} - Subtotal: {item.Subtotal():C}");
            }
            Console.WriteLine($"Total Bruto: {TotalBruto():C}");
        }
    }
}
