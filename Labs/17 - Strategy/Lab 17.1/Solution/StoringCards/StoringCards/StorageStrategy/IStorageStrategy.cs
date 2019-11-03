using System.Collections.Generic;

namespace StoringCards
{
    interface IStorageStrategy
    {
        IEnumerable<Card> Load();
        void Save( IEnumerable<Card> cards );
    }
}
