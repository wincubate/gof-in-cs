using System.Linq;
using Wincubate.RepositoryExamples.Data;

namespace Wincubate.RepositoryExamples
{
    interface IProductRepository : IRepository<Product>
    {
        IQueryable<Product> GetAllBooks();
    }
}
