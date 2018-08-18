using System;
using System.Collections.Generic;
using System.Linq;
using Wincubate.RepositoryExamples.Data;

namespace Wincubate.RepositoryExamples
{
    class InMemoryProductRepository : IProductRepository
    {
        private readonly List<Product> _products;

        public InMemoryProductRepository( params Product[] products )
        {
            _products = new List<Product>(products);
        }

        public Product GetById( int id ) => _products.Single(p => p.Id == id);

        public IEnumerable<Product> GetAll() => _products
            .ToList();

        public IEnumerable<Product> GetAllBooks() => _products
            .Where(p => p.Category == Category.Book)
            .ToList();

        public void Add( Product product )
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            int existingIndex = _products.FindIndex(p => p.Id == product.Id);
            if (existingIndex >= 0)
            {
                _products[existingIndex] = product;
            }
            else
            {
                _products.Add(product);
            }
        }

        public void Remove( Product product )
        {
            _products.Remove(product);
        }
    }
}
