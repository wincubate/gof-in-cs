using System;

namespace BrewingCoffee
{
    abstract class Coffee : ICoffee
    {
        public Coffee(
            CoffeeKind kind,
            int strength,
            CoffeeSize size )
        {
            Kind = kind;
            Strength = strength;
            Size = size;
        }

        public CoffeeKind Kind { get; }
        public int Strength { get; }
        public CoffeeSize Size { get; }

        public void Serve( string customerName )
        {
            Console.WriteLine($"Serving a {Size} {Kind} of strength {Strength} to {customerName}");
        }
    }
}