using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module14.Slide16
{
   /// <summary>
   /// General ViewModelBase class to derive concrete ViewModel classes
   /// from. Primarily provides notification infrastructure.
   /// </summary>
   /// <remarks>
   /// See http://msdn.microsoft.com/en-us/magazine/dd419663.aspx for a
   /// discussion of its elements.
   /// </remarks>
   public class ViewModelBase : INotifyPropertyChanged
   {
      public bool ThrowOnInvalidPropertyName
      {
         get;
         set;
      }

      #region INotifyPropertyChanged Members

      public event PropertyChangedEventHandler PropertyChanged;

      protected virtual void OnPropertyChanged( [CallerMemberName] string propertyName = null )
      {
         VerifyPropertyName( propertyName );

         PropertyChangedEventHandler del = PropertyChanged;
         if ( del != null )
         {
            var e = new PropertyChangedEventArgs( propertyName );
            del( this, e );
         }
      }

      #endregion

      [Conditional( "DEBUG" )]
      [DebuggerStepThrough]
      public void VerifyPropertyName( string propertyName )
      {
         // Verify that the property name matches a real,  
         // public, instance property on this object.
         if ( TypeDescriptor.GetProperties( this )[ propertyName ] == null )
         {
            string message = string.Format(
               "Invalid property name: \"{0}\".",
               propertyName
            );

            if ( ThrowOnInvalidPropertyName )
            {
               throw new NotSupportedException( message );
            }
            else
            {
               Debug.Fail( message );
            }
         }
      }
   }
}
