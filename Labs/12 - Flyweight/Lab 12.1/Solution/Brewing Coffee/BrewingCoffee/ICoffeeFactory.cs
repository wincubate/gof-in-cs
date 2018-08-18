namespace BrewingCoffee
{
    public interface ICoffeeFactory
    {
        ICoffee CreateCoffee( string coffeeType );
    }
}
