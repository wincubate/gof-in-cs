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

            ISetCommandFactory factory = new SetCommandFactory(light1, light2, light3);

            LoggingSwitch invoker = new LoggingSwitch();

            Random random = new Random((int)DateTime.Now.Ticks);
            while( true )
            {
                ICommand command = factory.CreateCommand(
                    random.Next(3),
                    random.Next(100)
                );
                invoker.Execute(command);

                Thread.Sleep(random.Next(5000));
            }
        }
    }
}
