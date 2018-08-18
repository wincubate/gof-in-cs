using System;

namespace Wincubate.CompositeExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleItem burger = new SingleItem { Description = "Mic Bag Burger", Price = 25 };
            SingleItem fries = new SingleItem { Description = "Curly Braces Fries", Price = 11 };
            SingleItem drink = new SingleItem { Description = "Pepsi Minimum", Price = 16 };
            SingleItem wrap = new SingleItem { Description = "Panel Wrap", Price = 22 };
            SingleItem shake = new SingleItem { Description = "Sharp Shake", Price = 15 };

            SingleItem[] order =
            {
                burger,
                fries,
                drink,
                wrap,
                shake
            };

            foreach (SingleItem item in order)
            {
                Console.WriteLine( item );
            }
        }
    }
}
