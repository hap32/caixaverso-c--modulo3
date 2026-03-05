using E7_1_CheckoutEcommerce.Interfaces;
using E7_1_CheckoutEcommerce.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7_1_CheckoutEcommerce.Models
{
    public class CarrinhoDeCompras
    {
        public decimal ValorTotal { get; private set; }

        public void AdicionarProduto(string descricao, decimal valorUnitario, int quantidade)
        {
            ValorTotal += valorUnitario * quantidade;
        }

        public void FinalizarCompra(IPagamento formaPagamento, Comprovante servicoComprovante)
        {
            formaPagamento.Pagar(ValorTotal);
            servicoComprovante.Gerar(ValorTotal);
        }

    }
}
