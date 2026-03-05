using E7_2_MiniSistemaCadastro.Domain.Entities;
using E7_2_MiniSistemaCadastro.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7_2_MiniSistemaCadastro.Infrastructure.Persistence
{
    public class NotaFiscalRepositorioEmMemoria : IRepositoryInt<NotaFiscal>
    {
        private readonly List<NotaFiscal> _dados = new();
        public void Inserir(NotaFiscal nf) => _dados.Add(nf);
        public IEnumerable<NotaFiscal> Listar() => _dados;
        public NotaFiscal BuscarPorId(int id) => _dados.FirstOrDefault(x => x.Numero == id);
        public void Atualizar(int id, NotaFiscal nf) { /* ..... */ }
    }
}
