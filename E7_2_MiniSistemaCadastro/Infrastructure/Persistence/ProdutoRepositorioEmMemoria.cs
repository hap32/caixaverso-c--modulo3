using E7_2_MiniSistemaCadastro.Domain.Entities;
using E7_2_MiniSistemaCadastro.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7_2_MiniSistemaCadastro.Infrastructure.Persistence
{
    public class ProdutoRepositorioEmMemoria : IRepositoryGuid<Produto>
    {
        protected readonly List<Produto> _produtos = new();
        public void Inserir(Produto entidade) => _produtos.Add(entidade);
        public IEnumerable<Produto> Listar() => _produtos;
        public Produto BuscarPorId(Guid id) => _produtos.FirstOrDefault(p => p.Id == id);
        public void Atualizar(Guid id, Produto entidade);
    }
}
