using ProjetoFinal.Domain.Entitites;
using ProjetoFinal.Domain.Interfaces;
using ProjetoFinal.Infrastructure.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Application
{
    public class PedidoProcessor : PedidoProcessorBase
    {
        private readonly IEnumerable<IDesconto> _descontos;
        private readonly IPagamento _pagamento;
        private readonly ILogger _logger;

        public PedidoProcessor(IEnumerable<IDesconto> descontos, IPagamento pagamento, ILogger logger)
        {
            _descontos = descontos;
            _pagamento = pagamento;
            _logger = logger;
        }

        protected override void ValidarPedido(Pedido pedido)
        {
            if (!pedido.Itens.Any()) throw new Exception("Pedido vazio.");
        }

        protected override decimal CalcularTotalBruto(Pedido pedido) => pedido.TotalBruto();

        protected override decimal CalcularDescontos(Pedido pedido)
        {
            decimal total = 0;
            foreach (var desc in _descontos)
            {
                total += desc.CalcularDesconto(pedido);
            }
            return total;
        }

        protected override void RealizarPagamento(decimal valorFinal) => _pagamento.Pagar(valorFinal);

        protected override void RegistrarLog(decimal bruto, decimal descontos, decimal valorFinal)
        {
            _logger.Info($"Total bruto: {bruto:F2}");
            _logger.Info($"Total descontos: {descontos:F2}");
            _logger.Info($"Total final: {valorFinal:F2}");
            _logger.Info($"Pagamento: {_pagamento.Nome}");
            _logger.Info("Status: Pago com sucesso");
        }
    }
}
