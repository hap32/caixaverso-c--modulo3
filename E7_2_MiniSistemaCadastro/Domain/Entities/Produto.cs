using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7_2_MiniSistemaCadastro.Domain.Entities
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
