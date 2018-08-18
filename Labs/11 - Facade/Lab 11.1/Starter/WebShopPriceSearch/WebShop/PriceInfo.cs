namespace WebShop
{
    public struct PriceInfo
    {
        public int ProductId { get; set; }
        public decimal PriceUsd { get; set; }

        public PriceInfo( int productId, decimal priceUsd )
        {
            ProductId = productId;
            PriceUsd = priceUsd;
        }
    }
}
