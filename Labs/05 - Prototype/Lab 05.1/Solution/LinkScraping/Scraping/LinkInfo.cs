using System;

namespace Scraping
{
    public class LinkInfo : ICloneable
    {
        public int Index { get; }
        public string Href { get; }

        #region ICloneable Members

        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion

        public LinkInfo( int index, string href )
        {
            Index = index;
            Href = href;
        }
    }
}
