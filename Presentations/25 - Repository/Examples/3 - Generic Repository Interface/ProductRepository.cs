using System;
using System.Linq;
using System.Linq.Expressions;
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

        public Product GetById( int id ) => _context.Products
            .Single(p => p.Id == id);

        public IQueryable<Product> GetAll() => _context.Products;

        public IQueryable<Product> GetAll( Expression<Func<Product, bool>> filter ) => _context.Products
            .Where(filter);

        public void Add( Product product )
        {
            _context.Products.Add(product ?? throw new ArgumentNullException(nameof(product)));
            _context.SaveChanges();
        }

        public void Remove( Product product )
        {
            _context.Products.Remove(product ?? throw new ArgumentNullException(nameof(product)));
            _context.SaveChanges();
        }

        public IQueryable<Product> GetAllBooks() => _context.Products
            .Where(p => p.Category == Category.Book);
    }
}