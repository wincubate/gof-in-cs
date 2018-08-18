namespace Wincubate.FlyweightExamples
{
    interface ICoffeeFactory
    {
        ICoffee CreateCoffee( string coffeeType );
    }
}
