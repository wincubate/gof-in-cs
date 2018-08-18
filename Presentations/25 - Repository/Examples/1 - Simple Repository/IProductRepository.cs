using System.Collections.Generic;
using Wincubate.RepositoryExamples.Data;

namespace Wincubate.RepositoryExamples
{
    interface IProductRepository
    {
        Product GetById( int id );
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetAllBooks();

        // Not needed (yet?) :
        //
        //void Add( Product product );
        //void Remove( Product product );
    }
}
