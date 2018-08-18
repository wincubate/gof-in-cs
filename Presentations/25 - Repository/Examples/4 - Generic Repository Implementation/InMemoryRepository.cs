using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Wincubate.RepositoryExamples.Data;

namespace Wincubate.RepositoryExamples
{
    class InMemoryRepository<T> : IRepository<T> where T : IEntity
    {
        private readonly List<T> _elements;

        public InMemoryRepository( params T[] products )
        {
            _elements = new List<T>(products);
        }

        public T GetById( int id ) => _elements.Single(p => p.Id == id);

        public IQueryable<T> GetAll() => _elements
            .AsQueryable();

        public IQueryable<T> GetAll( Expression<Func<T, bool>> filter ) => _elements
            .AsQueryable()
            .Where(filter);

        public void Add( T element )
        {
            if (element == null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            int existingIndex = _elements.FindIndex(p => p.Id == element.Id);
            if (existingIndex >= 0)
            {
                _elements[existingIndex] = element;
            }
            else
            {
                _elements.Add(element);
            }
        }

        public void Remove( T element )
        {
            _elements.Remove(element);
        }
    }
}
