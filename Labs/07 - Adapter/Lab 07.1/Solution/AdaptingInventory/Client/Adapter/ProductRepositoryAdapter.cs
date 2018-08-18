using System.Collections.Generic;
using System.Linq;

namespace Client.Adapter
{
    class ProductRepositoryAdapter : IInventoryRepository
    {
        private WebShop.ProductRepository _repository;

        public ProductRepositoryAdapter( WebShop.ProductRepository repository )
        {
            _repository = repository;
        }

        public IEnumerable<ItemGroup> GetItemGroups()
        {
            IEnumerable<WebShop.Product> products = _repository.GetAll();

            IEnumerable<ItemGroup> query = products
                .GroupBy(p => p.Category?.ToString() ?? "Uncategorized" )
                .Select(g => new ItemGroup
                {
                    Name = g.Key,
                    Count = g.Count(),
                    Items = g.Select( p => new Item
                    {
                        Name = p.Name,
                        Supplier = p.Manufacturer
                    })
                });

            return query;
        }
    }
}
