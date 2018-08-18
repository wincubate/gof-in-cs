namespace Wincubate.StrategyExamples
{
    class Order
    {
        public int Count { get; set; }
        public Product Product { get; set; }

        public decimal SuggestedSubtotal => Count * Product.SuggestedPrice;
    }
}
