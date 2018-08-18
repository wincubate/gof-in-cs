using System.Collections.Generic;

namespace StoringCards
{
    interface IStorageStrategy
    {
        List<Card> Load();
        void Save( List<Card> cards );
    }
}
