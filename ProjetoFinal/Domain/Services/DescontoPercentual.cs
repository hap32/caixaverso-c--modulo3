using ProjetoFinal.Domain.Entitites;
using ProjetoFinal.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Domain.Services
{
    public class DescontoPercentual : IDesconto
    {
        private readonly decimal _porcentagem;
        public string Nome => $"DescontoPercentual ({_porcentagem}%)";
        public DescontoPercentual(decimal porcentagem) => _porcentagem = porcentagem;
        public decimal CalcularDesconto(Pedido pedido) => pedido.TotalBruto() * (_porcentagem / 100);
    }
}
