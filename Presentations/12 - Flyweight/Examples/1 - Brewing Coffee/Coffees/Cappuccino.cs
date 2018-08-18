namespace Wincubate.FlyweightExamples
{
    class Cappuccino : Coffee
    {
        public Cappuccino( string customerName )
            : base(CoffeeKind.Cappuccino, 3, CoffeeSize.Regular, customerName)
        {
        }
    }
}
