using ProjetoFinal.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Domain.Entitites
{
    public class Produto : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public void Validar()
        {
            if (string.IsNullOrWhiteSpace(Nome)) throw new Exception("Nome é obrigatório.");
            if (Preco <= 0) throw new Exception("Preço deve ser maior que zero.");
        }
    }
}
