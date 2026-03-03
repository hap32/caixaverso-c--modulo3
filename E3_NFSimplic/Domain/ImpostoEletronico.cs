using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFSimplic.Domain
{
    //Imposto por faixa: Eletrônico acima de R$ 1000 tem 18% em vez de 15%
    internal class ImpostoEletronico : ImpostoBase
    {
        public override decimal Calcular(ItemNotaFiscal item)
        {
            if (item.Produto.Categoria != CategoriaProduto.Eletronico)
                return 0; // Sem imposto

            var subtotal = item.Subtotal();
            if (subtotal > 1000)
                return subtotal * 0.18m; // Imposto de 18% para eletrônicos acima de R$1000
            return item.Subtotal() * 0.15m; // Imposto de 15% para eletrônicos
        }
    }
}
