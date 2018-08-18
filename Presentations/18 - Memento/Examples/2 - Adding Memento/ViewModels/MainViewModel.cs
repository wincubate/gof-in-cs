using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace Wincubate.MementoExamples
{
    class MainViewModel : ViewModelBase
    {

        #region Properties

        public GuestsViewModel Guests { get; set; }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _name;

        public string Company
        {
            get
            {
                return _company;
            }
            set
            {
                if (_company != value)
                {
                    _company = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _company;

        #endregion

        #region Commands

        public ICommand AddGuestCommand => _addGuestCommand;
        private RelayCommand _addGuestCommand;

        public ICommand UndoCommand => _undoCommand;
        private RelayCommand _undoCommand;

        #endregion

        private readonly Stack<IGuestsMemento> _undoMementos;

        public MainViewModel()
        {
            _undoMementos = new Stack<IGuestsMemento>();
            Guests = new GuestsViewModel();

            Name = "Ash Williams";
            Company = "S-Mart";

            _addGuestCommand = new RelayCommand(
                AddGuest,
                CanAddGuest
            );

            _undoCommand = new RelayCommand(
                Undo,
                CanUndo
            );
        }

        private bool CanAddGuest( object o ) =>
            string.IsNullOrWhiteSpace(Name) == false &&
            string.IsNullOrWhiteSpace(Company) == false;

        private void AddGuest( object o )
        {
            // Save state
            _undoMementos.Push(Guests.Memento);

            Guests.Add(new Guest(Name, Company));

            Name = string.Empty;
            Company = string.Empty;
        }

        private bool CanUndo( object o ) => _undoMementos.Any();

        private void Undo( object o )
        {
            if( _undoMementos.Any() )
            {
                IGuestsMemento memento = _undoMementos.Pop();
                Guests.Memento = memento;
            }
        }
    }
}