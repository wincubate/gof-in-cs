using System;

namespace Wincubate.FlyweightExamples
{
    abstract class Coffee : ICoffee
    {
        public static int CoffeesCreated;

        public Coffee(
            CoffeeKind kind,
            int strength,
            CoffeeSize size,
            string customerName )
        {
            Kind = kind;
            Strength = strength;
            Size = size;
            CustomerName = customerName;

            CoffeesCreated++;
        }

        public CoffeeKind Kind { get; }
        public int Strength { get; }
        public CoffeeSize Size { get; }
        public string CustomerName { get; }

        public void Serve()
        {
            Console.WriteLine($"Serving a {Size} {Kind} of strength {Strength} to {CustomerName}");
        }
    }
}
