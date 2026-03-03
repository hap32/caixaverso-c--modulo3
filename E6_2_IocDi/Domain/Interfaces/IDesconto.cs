using ioc_di.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioc_di.Domain.Interfaces
{
    public interface IDesconto
    {
        string Nome { get; }
        decimal CalcularDesconto(Pedido pedido);
    }
}
