using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Wincubate.MementoExamples
{
    class GuestsViewModel : ObservableCollection<Guest>
    {
        private class GuestsViewModelMemento : IMemento
        {
            public object State { get; }

            public GuestsViewModelMemento( IEnumerable<Guest> guests )
            {
                State = guests.ToArray();
            }
        }

        public IMemento Memento
        {
            get => new GuestsViewModelMemento(this);
            set
            {
                Clear();

                // Make sure value indeed came from GuestsViewModel originally
                GuestsViewModelMemento memento = (GuestsViewModelMemento)value;
                foreach (Guest guest in memento.State as IEnumerable<Guest>)
                {
                    Add(guest);
                }
            }
        }
    }
}