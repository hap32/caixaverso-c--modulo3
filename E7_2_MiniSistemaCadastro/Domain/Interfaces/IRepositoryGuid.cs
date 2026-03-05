using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7_2_MiniSistemaCadastro.Domain.Interfaces
{
    public interface IRepositoryGuid<T> : IRepository<T>
    {
        T BuscarPorId(Guid id);
        void Atualizar(Guid id, T entidade);
    }
}
