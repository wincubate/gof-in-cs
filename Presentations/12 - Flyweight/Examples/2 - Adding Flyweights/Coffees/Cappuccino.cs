namespace Wincubate.FlyweightExamples
{
    class Cappuccino : Coffee
    {
        public Cappuccino()
            : base(CoffeeKind.Cappuccino, 3, CoffeeSize.Regular)
        {
        }
    }
}
