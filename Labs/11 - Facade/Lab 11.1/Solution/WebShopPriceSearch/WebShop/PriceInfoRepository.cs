using System.Collections.Generic;
using System.Linq;

namespace WebShop
{
    public class PriceInfoRepository
    {
        private List<PriceInfo> _prices;

        public PriceInfoRepository()
        {
            _prices = new List<PriceInfo>
            {
                new PriceInfo( 1, 3299 ),
                new PriceInfo( 2, 89 ),
                new PriceInfo( 3, 99 ),
                new PriceInfo( 4, 52 ),
                new PriceInfo( 5, 339 ),
                new PriceInfo( 6, 65 )
            };
        }

        public PriceInfo GetById( int id ) => _prices
            .Where(pi => pi.ProductId == id)
            .Single();

        public IEnumerable<PriceInfo> GetAll()
        {
            return _prices.ToList();
        }
    }
}
