using ProjetoFinal.Domain.Entitites;
using ProjetoFinal.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Domain.Services
{
    public class DescontoPorQuantidade : IDesconto
    {
        public string Nome => "Desconto Por Quantidade";
        public decimal CalcularDesconto(Pedido pedido) =>
            pedido.Itens.Sum(i => i.Quantidade) >= 5 ? 20.00m : 0;
    }
}
