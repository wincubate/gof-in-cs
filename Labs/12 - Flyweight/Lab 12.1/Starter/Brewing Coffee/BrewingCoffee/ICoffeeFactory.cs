namespace BrewingCoffee
{
    interface ICoffeeFactory
    {
        ICoffee CreateCoffee( string coffeeType );
    }
}
