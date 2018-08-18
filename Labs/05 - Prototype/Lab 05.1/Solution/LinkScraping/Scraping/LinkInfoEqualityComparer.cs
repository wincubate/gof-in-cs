using System.Collections.Generic;

namespace Scraping
{
    public class LinkInfoEqualityComparer : IEqualityComparer<LinkInfo>
    {
        public bool Equals( LinkInfo x, LinkInfo y ) =>
            (x == null && y == null) ||
            ((x != null && y != null) &&
              (x.Href == y.Href && x.Index == y.Index)
            );

        public int GetHashCode( LinkInfo obj ) =>
            (obj.Href, obj.Index).GetHashCode();
    }
}
