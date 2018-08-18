using System;
using System.Collections.Generic;
using System.Linq;
using Wincubate.RepositoryExamples.Data;
using Wincubate.RepositoryExamples.Data.EF;

namespace Wincubate.RepositoryExamples
{
    class ProductRepository : IProductRepository
    {
        private readonly ProductsContext _context;

        public ProductRepository()
        {
            _context = new ProductsContext();
        }

        public IEnumerable<Product> GetAll() => _context.Products
            .ToList();

        public IEnumerable<Product> GetAllBooks() => _context.Products
            .Where(p => p.Category == Category.Book)
            .ToList();

        public Product GetById( int id ) => _context.Products
            .Single(p => p.Id == id);

        //public void Add( Product product )
        //{
        //    _context.Products.Add(product ?? throw new ArgumentNullException(nameof(product)));
        //    _context.SaveChanges();
        //}

        //public void Remove( Product product )
        //{
        //    _context.Products.Remove(product ?? throw new ArgumentNullException(nameof(product)));
        //    _context.SaveChanges();
        //}
    }
}