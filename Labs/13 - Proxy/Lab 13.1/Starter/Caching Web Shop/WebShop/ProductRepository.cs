using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace WebShop
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products;
        private readonly Random _random;

        public ProductRepository()
        {
            _products = new List<Product>
            {
                new Product( 1, "HoloLens", "Microsoft", Category.Hardware ),
                new Product( 2, "Business Suit Boba Goes Looking for Love in Aldaraan Places", "Wincubate Games", Category.Software ),
                new Product( 3, "Design Patterns in C#", "Gang of One", Category.Book ),
                new Product( 4, "How to survive without Internet", "Chris MacDonald", Category.Book ),
                new Product( 5, "Switch", "Nintendo", Category.Hardware ),
                new Product( 6, "Switch Controller", "Nintendo", Category.Hardware )
            };
            _random = new Random((int)DateTime.Now.Ticks);
        }

        public Product GetById( int id )
        {
            int time = _random.Next(750);
            Thread.Sleep(time);
            Console.WriteLine($"Fetching Product ID {id} from ProductRepository in {time} ms");

            return _products.SingleOrDefault(p => p.Id == id) ??
                throw new ProductException($"Product ID {id} does not exist");
        }

        public IEnumerable<Product> GetAll()
        {
            int time = _random.Next(1000);
            Thread.Sleep(time);
            Console.WriteLine($"Fetching all products from ProductRepository in {time} ms");

            return _products.ToList();
        }

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
    }
}
