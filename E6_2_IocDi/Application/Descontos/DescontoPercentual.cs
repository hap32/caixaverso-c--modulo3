using ioc_di.Domain.Entities;
using ioc_di.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioc_di.Application.Descontos
{
    public class DescontoPercentual : IDesconto
    {
        private readonly decimal _percentual;

        public string Nome => "Desconto Percentual";

        public DescontoPercentual(decimal percentual)
        {
            _percentual = percentual;
        }

        public decimal CalcularDesconto(Pedido pedido)
        {
            return pedido.TotalBruto() * _percentual;
        }
    }
}
