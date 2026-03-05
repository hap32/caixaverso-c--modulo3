using ProjetoFinal.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Infrastructure.Repositories
{
    public class InMemoryRepository<T> : IRepository<T> where T : IEntity
    {
        private readonly List<T> _items = new();
        public void Add(T entity) => _items.Add(entity);
        public IEnumerable<T> GetAll() => _items;
    }
}
