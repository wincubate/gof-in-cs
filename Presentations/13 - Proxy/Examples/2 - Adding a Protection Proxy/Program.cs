using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using Wincubate.ProxyExamples.WebShop;

namespace Wincubate.ProxyExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);

            IProductRepository products = new AdministratorsOnlyProxyRepository(
                new ProductRepository()
            );
            products.Add(new Product(7, "Proxying Proxies", "P. Atternborough", Category.Book));

            IEnumerable<Product> books = products
                            .GetAll()
                            .Where(p => p.Category == Category.Book);

            foreach (Product product in books)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("Done...");
            Console.ReadLine();
        }
    }
}
