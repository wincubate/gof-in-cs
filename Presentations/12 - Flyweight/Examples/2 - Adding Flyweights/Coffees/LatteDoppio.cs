namespace Wincubate.FlyweightExamples
{
    class LatteDoppio : Coffee
    {
        public LatteDoppio()
            : base(CoffeeKind.Latte, 2, CoffeeSize.Regular)
        {
        }
    }
}
