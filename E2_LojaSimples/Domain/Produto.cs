using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaSimples.Dominio
{
    public class Produto
    {   
        public int id { get; private set; }
        public string nome { get; private set; }
        public decimal preco { get; private set; }

        public Produto(int id, string nome, decimal preco)
        {
            if (string.IsNullOrWhiteSpace(nome))          
                throw new ArgumentException("Nome é obrigatório.");

            if (preco <= 0) throw new ArgumentException("Preço deve ser > 0.");

            this.id = id;
            this.nome = nome;
            this.preco = preco;
        }
    }
}
