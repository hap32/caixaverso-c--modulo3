using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFSimplic.Domain
{
    public abstract class ImpostoBase
    {
        public abstract decimal Calcular(ItemNotaFiscal item);
    }
}
