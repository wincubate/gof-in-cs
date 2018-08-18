using System;
using System.Linq;
using System.Linq.Expressions;
using Wincubate.RepositoryExamples.Data;

namespace Wincubate.RepositoryExamples
{
    interface IRepository<T> where T : IEntity
    {
        T GetById( int id );
        IQueryable<T> GetAll();
        IQueryable<T> GetAll( Expression<Func<T, bool>> filter );
        void Add( T product );
        void Remove( T product );
    }
}
