using System;
using System.Linq;
using Wincubate.RepositoryExamples.Data;
using Wincubate.RepositoryExamples.Data.EF;

namespace Wincubate.RepositoryExamples
{
    class Program
    {
        static void Main( string[] args )
        {
            using (ProductsContext context = new ProductsContext())
            {
                var query = context
                        .Products
                        .Where(p => p.Category == Category.Book);

                foreach (var product in query)
                {
                    Console.WriteLine(product);
                }
            }
        }
    }
}