namespace Wincubate.FlyweightExamples
{
    class LatteTriplo : Coffee
    {
        public LatteTriplo( string customerName )
            : base(CoffeeKind.Latte, 2, CoffeeSize.Large, customerName)
        {
        }
    }
}
