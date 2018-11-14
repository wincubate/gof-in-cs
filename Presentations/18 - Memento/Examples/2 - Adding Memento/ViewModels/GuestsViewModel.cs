using System.Collections.ObjectModel;

namespace Wincubate.MementoExamples
{
    class GuestsViewModel : ObservableCollection<Guest>
    {
        public IGuestsMemento Memento
        {
            get => new GuestsViewModelMemento(this);
            set
            {
                Clear();
                foreach( Guest g in value.State )
                {
                    Add(g);
                }
            }
        }
    }
}
