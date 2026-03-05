using E7_2_MiniSistemaCadastro.Domain.Entities;
using E7_2_MiniSistemaCadastro.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7_2_MiniSistemaCadastro.Infrastructure.Persistence
{
    public class ProdutoRepositorioComValidacao : ProdutoRepositorioEmMemoria
    {
        public override void Inserir(Produto entidade)
        {
            if (string.IsNullOrWhiteSpace(entidade.Descricao))
                throw new ArgumentException("Descrição inválida!");
            base.Inserir(entidade);
        }
    }
}
