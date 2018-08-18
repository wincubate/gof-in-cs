using System;

namespace Wincubate.BuilderExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            HawaiiPizzaBuilder builder = new HawaiiPizzaBuilder();
            builder.Build();
            Pizza hawaii = builder.Product;

            Console.WriteLine(hawaii);
        }
    }
}
