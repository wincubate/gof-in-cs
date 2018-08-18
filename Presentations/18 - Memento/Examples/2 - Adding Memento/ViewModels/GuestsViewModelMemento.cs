using System.Collections.Generic;
using System.Linq;

namespace Wincubate.MementoExamples
{
    class GuestsViewModelMemento : IGuestsMemento
    {
        public Guest[] State { get; }

        public GuestsViewModelMemento( IEnumerable<Guest> guests )
        {
            State = guests.ToArray();
        }
    }
}
