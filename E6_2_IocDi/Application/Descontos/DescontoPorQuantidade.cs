using ioc_di.Domain.Entities;
using ioc_di.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioc_di.Application.Descontos
{
    public class DescontoPorQuantidade : IDesconto
    {
        private readonly int _minItens;
        private readonly decimal _valorFixo;

        public string Nome => "Desconto por Quantidade";

        public DescontoPorQuantidade(int minItens, decimal valorFixo)
        {
            _minItens = minItens;
            _valorFixo = valorFixo;
        }

        public decimal CalcularDesconto(Pedido pedido)
        {
            return pedido.TotalItens() >= _minItens
                ? _valorFixo
                : 0m;
        }
    }
}
