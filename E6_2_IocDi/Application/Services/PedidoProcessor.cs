using ioc_di.Domain.Entities;
using ioc_di.Domain.Interfaces;
using ioc_di.Infrastructure.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioc_di.Application.Services
{
    public class PedidoProcessor
    {
        private readonly IEnumerable<IDesconto> _descontos;
        private readonly IPagamento _pagamento;
        private readonly ILogger _logger;

        public PedidoProcessor(
            IEnumerable<IDesconto> descontos,
            IPagamento pagamento,
            ILogger logger)
        {
            _descontos = descontos;
            _pagamento = pagamento;
            _logger = logger;
        }

        public void Processar(Pedido pedido)
        {
            try
            {
                var bruto = pedido.TotalBruto();

                var totalDescontos = _descontos
                    .Sum(d => d.CalcularDesconto(pedido));

                var totalFinal = bruto - totalDescontos;

                if (totalFinal < 0)
                    totalFinal = 0;

                _pagamento.Pagar(totalFinal);

                _logger.Info($"""
                Pedido processado:
                Total bruto: {bruto:C}
                Total descontos: {totalDescontos:C}
                Total final: {totalFinal:C}
                Pagamento: {_pagamento.Nome}
                """);
            }
            catch (Exception ex)
            {
                _logger.Error($"Erro ao processar pedido: {ex.Message}");
            }
        }
    }
}
