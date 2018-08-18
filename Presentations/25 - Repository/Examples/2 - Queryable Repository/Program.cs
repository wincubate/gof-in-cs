using System;
using System.Collections.Generic;
using System.Linq;
using Wincubate.RepositoryExamples.Data;

namespace Wincubate.RepositoryExamples
{
    class Program
    {
        static void Main( string[] args )
        {
            IProductRepository repository = new ProductRepository();
            //IProductRepository repository = new InMemoryProductRepository(
            //    new Product { Id = 1, Name = "Continuum Transfunctioner", Manufacturer = "Universal Stuff Inc.", Category = Category.Hardware },
            //    new Product { Id = 2, Name = "Necronomicon Ex Mortis", Manufacturer = "Deadite Press", Category = Category.Book }
            //);

            // Method 1:
            //IEnumerable<Product> query = repository.GetAll().Where(p => p.Category == Category.Book);

            // Method 2:
            IEnumerable<Product> query = repository.GetAll(p => p.Category == Category.Book);
            foreach (var product in query)
            {
                Console.WriteLine(product);
            }
        }
    }
}