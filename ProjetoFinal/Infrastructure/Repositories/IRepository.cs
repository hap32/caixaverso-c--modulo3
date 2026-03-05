using ProjetoFinal.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Infrastructure.Repositories
{
    public interface IRepository<T> where T : IEntity
    {
        void Add(T entity);
        IEnumerable<T> GetAll();
    }
}
