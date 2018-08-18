using System;
using System.Collections.Generic;
using Wincubate.FlyweightExamples.Utility;

namespace Wincubate.FlyweightExamples
{
    class Program
    {
        static void Main( string[] args )
        {
            RandomNameGenerator rng = new RandomNameGenerator();
            ICoffeeFactory factory = new CoffeeFactory();

            for (int i = 0; i < 1000; i++)
            {
                ICoffee c1 = factory.CreateCoffee(nameof(Cappuccino));
                c1.Serve(rng.GetRandomName());
                ICoffee c2 = factory.CreateCoffee(nameof(Espresso));
                c2.Serve(rng.GetRandomName());
                ICoffee c3 = factory.CreateCoffee(nameof(LatteDoppio));
                c3.Serve(rng.GetRandomName());
                ICoffee c4 = factory.CreateCoffee(nameof(LatteGrande));
                c4.Serve(rng.GetRandomName());
                ICoffee c5 = factory.CreateCoffee(nameof(LatteTriplo));
                c5.Serve(rng.GetRandomName());
            }

            Console.WriteLine();
            Console.WriteLine($"{Coffee.CoffeesCreated} objects created");
        }
    }
}
