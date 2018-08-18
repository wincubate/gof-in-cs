using System;
using System.Threading;
using Wincubate.FacadeExamples.ApplicationApi; // <--- Notice this is not needed
using Wincubate.FacadeExamples.SettingsApi;    // <--- Notice this is not needed

namespace Wincubate.FacadeExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            LongWalkFacade facade = new LongWalkFacade();
            facade.Set();

            Console.WriteLine( $"{Environment.NewLine}Long Walk beginning... :-)" );
            Thread.Sleep(5000);
            Console.WriteLine($"Long Walk ended :-){Environment.NewLine}");

            facade.Revert();
        }
    }
}