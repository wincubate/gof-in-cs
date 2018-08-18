using System;
using System.Collections.Generic;

namespace Wincubate.FlyweightExamples
{
    class CoffeeFactory : ICoffeeFactory
    {
        private readonly IDictionary<string, ICoffee> _coffees;

        public CoffeeFactory()
        {
            _coffees = new Dictionary<string, ICoffee>();
        }

        public ICoffee CreateCoffee( string coffeeType )
        {
            bool exists = _coffees.ContainsKey(coffeeType);
            if (exists == false)
            {
                // This could be done easier of course ;-)
                // See Module 02
                switch (coffeeType)
                {
                    case nameof(Cappuccino):
                        _coffees[coffeeType] = new Cappuccino();
                        break;
                    case nameof(Espresso):
                        _coffees[coffeeType] = new Espresso();
                        break;
                    case nameof(LatteDoppio):
                        _coffees[coffeeType] = new LatteDoppio();
                        break;
                    case nameof(LatteGrande):
                        _coffees[coffeeType] = new LatteGrande();
                        break;
                    case nameof(LatteTriplo):
                        _coffees[coffeeType] = new LatteTriplo();
                        break;
                    default:
                        throw new NotSupportedException($"Coffee type {coffeeType} not supported");
                }
            }

            return _coffees[coffeeType];
        }
    }
}
