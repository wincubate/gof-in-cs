using System;
using Wincubate.FlyweightExamples.Utility;

namespace Wincubate.FlyweightExamples
{
    class Program
    {
        static void Main( string[] args )
        {
            RandomNameGenerator rng = new RandomNameGenerator();

            for (int i = 0; i < 1000; i++)
            {
                ICoffee c1 = new Cappuccino(rng.GetRandomName());
                c1.Serve();
                ICoffee c2 = new Espresso(rng.GetRandomName());
                c2.Serve();
                ICoffee c3 = new LatteDoppio(rng.GetRandomName());
                c3.Serve();
                ICoffee c4 = new LatteGrande(rng.GetRandomName());
                c4.Serve();
                ICoffee c5 = new LatteTriplo(rng.GetRandomName());
                c5.Serve();
            }

            //Console.WriteLine();
            //Console.WriteLine( $"{Coffee.CoffeesCreated} objects created");
        }
    }
}
