using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioc_di.Domain.Entities
{
    public class Produto
    {
        public string Nome { get; }
        public decimal Preco { get; }

        public Produto(string nome, decimal preco)
        {
            if (preco <= 0)
                throw new ArgumentException("Preço deve ser maior que zero.");

            Nome = nome;
            Preco = preco;
        }
    }
}
