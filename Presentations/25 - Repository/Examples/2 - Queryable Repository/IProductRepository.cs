using System;
using System.Linq;
using System.Linq.Expressions;
using Wincubate.RepositoryExamples.Data;

namespace Wincubate.RepositoryExamples
{
    interface IProductRepository
    {
        Product GetById( int id );
        IQueryable<Product> GetAll();
        IQueryable<Product> GetAll( Expression<Func<Product, bool>> filter );
        void Add( Product product );
        void Remove( Product product );
    }
}
