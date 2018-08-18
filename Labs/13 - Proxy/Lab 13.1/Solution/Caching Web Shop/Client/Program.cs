using System;
using System.Collections.Generic;
using WebShop;

namespace Client
{
    class Program
    {
        static void Main( string[] args )
        {
            using (CachingProductRepository repository = new CachingProductRepository(new ProductRepository()))
            {
                IEnumerable<Product> all = repository.GetAll();
                IEnumerable<Product> all2 = repository.GetAll();

                Product p0 = repository.GetById(1);
                Console.WriteLine(p0);
                Product p1 = repository.GetById(1);
                Console.WriteLine(p1);
                Product p2 = repository.GetById(3);
                Console.WriteLine(p2);
                Product p3 = repository.GetById(1);
                Console.WriteLine(p3);
                Product p4 = repository.GetById(1);
                Console.WriteLine(p4);
                Product p5 = repository.GetById(1);
                Console.WriteLine(p5);
                Product p6 = repository.GetById(3);
                Console.WriteLine(p6);
            }
        }
    }
}
