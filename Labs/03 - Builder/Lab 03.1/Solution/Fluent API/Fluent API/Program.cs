using System;

namespace Wincubate.BuilderLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            FluentPizzaBuilder builder = new FluentPizzaBuilder();
            Pizza hawaii = builder
                .Begin()
                .WithCrust(CrustKind.Classic)
                .Sauce
                .AddTopping(ToppingKind.Ham)
                .AddTopping(ToppingKind.Pineapple)
                .AddCheese()
                .Oregano
                .Build();

            Console.WriteLine( hawaii );
        }
    }
}
