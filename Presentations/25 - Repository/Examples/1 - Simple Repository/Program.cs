using System;
using System.Collections.Generic;
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

            IEnumerable<Product> query = repository.GetAllBooks();
            foreach (var product in query)
            {
                Console.WriteLine(product);
            }
        }
    }
}