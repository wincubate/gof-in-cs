using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop
{
    public interface IProductRepository
    {
        Product GetById( int id );
        IEnumerable<Product> GetAll();
        void Add( Product product );
    }
}
