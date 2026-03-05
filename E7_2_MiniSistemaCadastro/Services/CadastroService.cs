using E7_2_MiniSistemaCadastro.Domain.Entities;
using E7_2_MiniSistemaCadastro.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7_2_MiniSistemaCadastro.Services
{
    C#
public interface ILogger { void Log(string mensagem); }
    [cite: 129]
    

    public class CadastroService
    {
        private readonly IRepositoryGuid<Produto> _repoProd;
        private readonly IRepositoryInt<NotaFiscal> _repoNF;
        private readonly ILogger _logger;

        public CadastroService(IRepositoryGuid<Produto> repoProd, IRepositoryInt<NotaFiscal> repoNF, ILogger logger)
        {
            [cite_start] _repoProd = repoProd; [cite: 111]
        _repoNF = repoNF;
            _logger = logger;
        }

        public void CadastrarProduto(Produto p)
        {
            try
            {
                [cite_start] _repoProd.Inserir(p); [cite: 133]
            [cite_start] _logger.Log($"Produto {p.Descricao} cadastrado."); [cite: 134]
        }
            catch (Exception ex)
            {
                [cite_start] _logger.Log($"Erro: {ex.Message}"); [cite: 138]
        }
        }
    }
}
