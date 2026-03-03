using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFSimplic.Domain
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public CategoriaProduto Categoria { get; private set; }

        public Produto(int id, string nome, decimal preco, CategoriaProduto categoria)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Categoria = categoria;
        }

        public void SetPreco(decimal novoPreco)
        {
            if (novoPreco <= 0)
                throw new ArgumentException("Preço deve ser maior que zero.");
            Preco = novoPreco;
        }

        public void SetNome(string novoNome)
        {
            if (string.IsNullOrWhiteSpace(novoNome))
                throw new ArgumentException("Nome é obrigatório.");
            Nome = novoNome;
        }
    }
}
