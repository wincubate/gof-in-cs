using System.Collections.ObjectModel;

namespace Wincubate.MementoExamples
{
    class GuestsViewModel : ObservableCollection<Guest>
    {
        public IGuestsMemento Memento
        {
            get => new GuestsViewModelMemento(Items);
            set
            {
                ClearItems();
                foreach( Guest g in value.State )
                {
                    Add(g);
                }
            }
        }
    }
}
