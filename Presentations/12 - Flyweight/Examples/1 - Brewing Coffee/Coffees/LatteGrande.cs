namespace Wincubate.FlyweightExamples
{
    class LatteGrande : Coffee
    {
        public LatteGrande( string customerName )
            : base(CoffeeKind.Latte, 1, CoffeeSize.Regular, customerName)
        {
        }
    }
}
