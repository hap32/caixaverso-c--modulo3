using NFSimplic.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFSimplic.Services
{
    //Não pode existir if/else calculando imposto por categoria dentro da calculadora.
    internal class CalculadoraImpostos
    {
        public decimal CalcularTotalImpostos(
            NotaFiscal notaFiscal,
            List<ImpostoBase> impostos)
        {
            decimal totalImpostos = 0;

            foreach (var item in notaFiscal.Itens)
            {
                foreach (var imposto in impostos)
                {
                    totalImpostos += imposto.Calcular(item);
                }
            }

            return totalImpostos;
        }
    }
}
