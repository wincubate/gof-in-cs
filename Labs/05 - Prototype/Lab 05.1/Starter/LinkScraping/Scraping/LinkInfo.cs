using System;
using System.Collections.Generic;
using System.Text;

namespace Scraping
{
    public class LinkInfo
    {
        public int Index { get; }
        public string Href { get; }

        public LinkInfo( int index, string href )
        {
            Index = index;
            Href = href;
        }
    }
}
