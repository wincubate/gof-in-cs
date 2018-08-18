namespace Wincubate.FlyweightExamples
{
    class Espresso : Coffee
    {
        public Espresso()
            : base(CoffeeKind.Espresso, 5, CoffeeSize.Small)
        {
        }
    }
}
