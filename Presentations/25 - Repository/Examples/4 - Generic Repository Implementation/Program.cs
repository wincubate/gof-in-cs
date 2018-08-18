using System;
using System.Collections.Generic;
using Wincubate.RepositoryExamples.Data;
using Wincubate.RepositoryExamples.Data.EF;

namespace Wincubate.RepositoryExamples
{
    class Program
    {
        static void Main( string[] args )
        {
            IRepository<Product> repository = new Repository<Product>( new ProductsContext() );

            //IRepository<Product> repository = new InMemoryRepository<Product>(
            //    new Product { Id = 1, Name = "Continuum Transfunctioner", Manufacturer = "Universal Stuff Inc.", Category = Category.Hardware },
            //    new Product { Id = 2, Name = "Necronomicon Ex Mortis", Manufacturer = "Deadite Press", Category = Category.Book }
            //);

            IEnumerable<Product> query = repository.GetAll(p => p.Category == Category.Book);
            foreach (var product in query)
            {
                Console.WriteLine(product);
            }
        }
    }
}