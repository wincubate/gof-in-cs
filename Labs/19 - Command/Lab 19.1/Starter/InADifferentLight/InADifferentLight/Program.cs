using System;
using System.Threading;

namespace InADifferentLight
{
    class Program
    {
        static void Main( string[] args )
        {
            LedLight light1 = new LedLight(ConsoleColor.Cyan);
            LedLight light2 = new LedLight(ConsoleColor.Red);
            LedLight light3 = new LedLight(ConsoleColor.Yellow);

            // TODO

            Random random = new Random((int)DateTime.Now.Ticks);
            while( true )
            {
                // TODO

                // ICommand command = ...; <--- Create SetCommand with random parameters

                Thread.Sleep(random.Next(5000));
            }
        }
    }
}
