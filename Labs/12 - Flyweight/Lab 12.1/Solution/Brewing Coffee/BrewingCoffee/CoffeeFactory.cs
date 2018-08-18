using System;
using System.Collections.Concurrent;

namespace BrewingCoffee
{
    public class CoffeeFactory : ICoffeeFactory
    {
        private readonly ConcurrentDictionary<string, ICoffee> _coffees;

        public CoffeeFactory()
        {
            _coffees = new ConcurrentDictionary<string, ICoffee>();
        }

        public ICoffee CreateCoffee( string coffeeType )
        {
            Func<string, ICoffee> instantiationFunction = null;

            switch (coffeeType)
            {
                case nameof(Cappuccino):
                    instantiationFunction = _ => new Cappuccino();
                    break;
                case nameof(Espresso):
                    instantiationFunction = _ => new Espresso();
                    break;
                case nameof(LatteDoppio):
                    instantiationFunction = _ => new LatteDoppio();
                    break;
                case nameof(LatteGrande):
                    instantiationFunction = _ => new LatteGrande();
                    break;
                case nameof(LatteTriplo):
                    instantiationFunction = _ => new LatteTriplo();
                    break;
                default:
                    throw new NotSupportedException($"Coffee type {coffeeType} not supported");
            }

            return _coffees.GetOrAdd(coffeeType, instantiationFunction);
        }
    }
}
