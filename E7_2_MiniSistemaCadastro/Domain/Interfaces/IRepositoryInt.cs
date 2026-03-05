using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7_2_MiniSistemaCadastro.Domain.Interfaces
{
    public interface IRepositoryInt<T> : IRepository<T>
    {
        T BuscarPorId(int id);
        void Atualizar(int id, T entidade);
    }
}
