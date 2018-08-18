using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Wincubate.Module14.Slide16
{
   /// <summary>
   /// RelayCommand as implemented by MVVM frameworks. It is sometimes
   /// called DelegateCommand, but plays an identical role.
   /// </summary>
   /// <remarks>
   /// See http://msdn.microsoft.com/en-us/magazine/dd419663.aspx for a
   /// discussion of its elements.
   /// </remarks>
   public class RelayCommand : ICommand
   {
      private readonly Predicate<object> _canExecute;
      private readonly Action<object> _executeAction;

      #region ICommand Members

      [DebuggerStepThrough]
      public bool CanExecute( object parameter )
      {
         return ( _canExecute == null ? true : _canExecute( parameter ) );
      }

      public void Execute( object parameter )
      {
         _executeAction( parameter );
      }

      public event EventHandler CanExecuteChanged
      {
         add
         {
            CommandManager.RequerySuggested += value;
         }
         remove
         {
            CommandManager.RequerySuggested -= value;
         }
      }

      #endregion

      public RelayCommand( Action<object> execute,
                           Predicate<object> canExecute = null )
      {
         Debug.Assert( execute != null );

         _executeAction = execute;
         _canExecute = canExecute;
      }
   }
}
