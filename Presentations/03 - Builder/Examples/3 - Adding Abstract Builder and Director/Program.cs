using System;

namespace Wincubate.BuilderExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaDirector maker = new PizzaDirector(
                new HawaiiPizzaBuilder()
            );
            Pizza hawaii = maker.Build();

            Console.WriteLine(hawaii);
        }
    }
}
