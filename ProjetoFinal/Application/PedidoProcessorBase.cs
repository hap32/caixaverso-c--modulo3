using ProjetoFinal.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Application
{
    public abstract class PedidoProcessorBase
    {
        public void Processar(Pedido pedido)
        {
            ValidarPedido(pedido);
            decimal bruto = CalcularTotalBruto(pedido);
            decimal descontos = CalcularDescontos(pedido);
            decimal valorFinal = CalcularTotalFinal(bruto, descontos);
            RealizarPagamento(valorFinal);
            RegistrarLog(pedido, bruto, descontos, valorFinal);
        }

        protected abstract void ValidarPedido(Pedido pedido);
        protected abstract decimal CalcularTotalBruto(Pedido pedido);
        protected abstract decimal CalcularDescontos(Pedido pedido);
        protected virtual decimal CalcularTotalFinal(decimal bruto, decimal descontos) => bruto - descontos;
        protected abstract void RealizarPagamento(decimal valorFinal);
        protected abstract void RegistrarLog(Pedido pedido, decimal bruto, decimal descontos, decimal valorFinal);
    }
}
