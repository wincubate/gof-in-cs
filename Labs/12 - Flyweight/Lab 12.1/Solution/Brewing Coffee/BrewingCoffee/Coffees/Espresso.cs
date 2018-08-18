namespace BrewingCoffee
{
    public class Espresso : Coffee
    {
        public Espresso()
            : base(CoffeeKind.Espresso, 5, CoffeeSize.Small)
        {
        }
    }
}
