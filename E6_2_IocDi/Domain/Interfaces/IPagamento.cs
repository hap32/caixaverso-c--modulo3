using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioc_di.Domain.Interfaces
{
    public interface IPagamento
    {
        string Nome { get; }
        void Pagar(decimal valor);
    }
}
