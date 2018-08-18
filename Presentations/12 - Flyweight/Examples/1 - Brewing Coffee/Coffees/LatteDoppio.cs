namespace Wincubate.FlyweightExamples
{
    class LatteDoppio : Coffee
    {
        public LatteDoppio( string customerName )
            : base(CoffeeKind.Latte, 2, CoffeeSize.Regular, customerName)
        {
        }
    }
}
