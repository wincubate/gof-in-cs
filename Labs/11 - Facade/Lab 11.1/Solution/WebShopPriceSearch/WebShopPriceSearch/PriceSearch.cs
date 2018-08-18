using System.Collections.Generic;
using System.Linq;

namespace WebShopPriceSearch
{
    class PriceSearch
    {
        private readonly WebShop.ProductRepository _productRepository;
        private readonly WebShop.PriceInfoRepository _priceInfoRepository;
        private readonly Financial.CurrencyConversionService _currentConversionService;

        public PriceSearch()
        {
            _productRepository = new WebShop.ProductRepository();
            _priceInfoRepository = new WebShop.PriceInfoRepository();
            _currentConversionService = new Financial.CurrencyConversionService();
        }

        public IEnumerable<PriceSearchInfo> Lookup( string searchName )
        {
            // Get all products matching the search name
            IEnumerable<(string ProductName, WebShop.PriceInfo PriceInfoUsd)> infos =
                _productRepository.GetAll()
                    .Where(p => p.Name.ToLower().Contains(searchName.ToLower()))
                    .Select(p =>
                        (ProductName: p.Name, PriceInfo: _priceInfoRepository.GetById(p.Id))
                    );
            
            // Convert each enriched info with the USD->DKK converted price 
            IEnumerable<PriceSearchInfo> searchInfos = infos.Select(info => new PriceSearchInfo
            {
                ProductName = info.ProductName,
                PriceDkk = _currentConversionService.Convert(
                        new Financial.CurrencyValue
                        {
                            Symbol = Financial.CurrencySymbol.USD,
                            Amount = info.PriceInfoUsd.PriceUsd
                        },
                        Financial.CurrencySymbol.DKK
                    ).Amount
            });

            return searchInfos;
        }
    }
}
