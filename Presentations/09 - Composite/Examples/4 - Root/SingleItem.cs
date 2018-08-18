namespace Wincubate.CompositeExamples
{
    class SingleItem : IOrderItem
    {
        public string Description { get; set; }
        public decimal Price { get; set; }

        public override string ToString() => $"{Description} [DKK {Price}]";
    }
}
