using System;

namespace BrewingCoffee
{
    public abstract class Coffee : ICoffee
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

        public override bool Equals( object obj )
        {
            if( obj is ICoffee )
            {
                ICoffee other = obj as ICoffee;
                return Kind == other.Kind &&
                    Strength == other.Strength &&
                    Size == other.Size;
            }

            return false;
        }

        public override int GetHashCode() => (Kind, Strength, Size).GetHashCode();

        public static bool operator == ( Coffee c1, Coffee c2 ) => c1.Equals(c2);

        public static bool operator !=( Coffee c1, Coffee c2 ) => !c1.Equals(c2);

        public void Serve( string customerName )
        {
            Console.WriteLine($"Serving a {Size} {Kind} of strength {Strength} to {customerName}");
        }
    }
}