using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using Wincubate.RepositoryExamples.Data;

namespace Wincubate.RepositoryExamples
{
    class Repository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly DbContext _context;

        public Repository( DbContext context )
        {
            _context = context;
        }

        public T GetById( int id ) => _context.Set<T>()
            .Single(p => p.Id == id);

        public IQueryable<T> GetAll() => _context.Set<T>();

        public IQueryable<T> GetAll( Expression<Func<T, bool>> filter ) => _context.Set<T>()
            .Where(filter);

        public void Add( T t )
        {
            _context.Set<T>().Add(t ?? throw new ArgumentNullException(nameof(t)));
            _context.SaveChanges();
        }

        public void Remove( T t )
        {
            _context.Set<T>().Remove(t ?? throw new ArgumentNullException(nameof(t)));
            _context.SaveChanges();
        }
    }
}