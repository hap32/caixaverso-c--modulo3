using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7_2_MiniSistemaCadastro.Domain.Interfaces
{
    public interface IRepository<T>
    {
        void Inserir(T entidade);
        IEnumerable<T> Listar();
    }
}
