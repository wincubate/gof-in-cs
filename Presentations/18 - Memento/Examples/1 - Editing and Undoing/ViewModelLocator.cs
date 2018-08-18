using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module14.Slide16
{
   /// <summary>
   /// This class contains static references to all the view models in the
   /// application and provides an entry point for the bindings.
   /// </summary>
   public class ViewModelLocator
   {
      private static MainViewModel _main;
      private static ParticipantsViewModel _participants;

      public MainViewModel Main
      {
         get
         {
            return _main;
         }
      }

      public ParticipantsViewModel Participants
      {
         get
         {
            return _participants;
         }
      }

      public ViewModelLocator()
      {
         _main = new MainViewModel();

         // Use Repository pattern or similar here instead!!
         _participants = new ParticipantsViewModel( new Wincubate.Module14.Data.Participants() );
      }
   }
}
