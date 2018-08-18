namespace Financial
{
    public class CurrencyConversionService
    {
        private decimal[,] _conversionTable =
        {
            { 1m, 0.1592m, 0.1196m }, // DKK -> DKK, USD, GBP
            { 6.2812m, 1m, 0.7512m }, // USD -> DKK, USD, GBP
            { 8.3613m, 1.3312m, 1m }  // GPB -> DKK, USD, GBP
        };

        public CurrencyConversionService()
        {
        }

        public CurrencyValue Convert( CurrencyValue from, CurrencySymbol to ) =>
            new CurrencyValue
            {
                Symbol = to,
                Amount = from.Amount * _conversionTable[(int)from.Symbol, (int)to]
            };
    }
}