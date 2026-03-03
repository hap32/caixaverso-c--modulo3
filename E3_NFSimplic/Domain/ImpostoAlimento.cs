using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFSimplic.Domain
{
    public class ImpostoAlimento : ImpostoBase
    {
        public override decimal Calcular(ItemNotaFiscal item)
        {
            if (item.Produto.Categoria != CategoriaProduto.Alimento)
                return 0; // Sem imposto
            return item.Subtotal() * 0.05m; // Imposto de 5% para alimentos
        }
    }
}
