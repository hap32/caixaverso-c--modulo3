using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFSimplic.Domain
{
    internal class ImpostoServico : ImpostoBase
    {
        public override decimal Calcular(ItemNotaFiscal item)
        {
            if (item.Produto.Categoria != CategoriaProduto.Servico)
                return 0; // Sem imposto
            return item.Subtotal() * 0.12m; // Imposto de 12% para serviços
        }
    }
}
