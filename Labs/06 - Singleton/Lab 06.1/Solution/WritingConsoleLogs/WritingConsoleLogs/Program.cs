using System;

namespace WritingConsoleLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogger logger1 = ConsoleLogger.Instance;
            logger1.Log( "Hey! We're running fine" );

            ConsoleLogger logger2 = ConsoleLogger.Instance;
            logger2.Log( "Houston, we have a problem...!" + Environment.NewLine, true);

            Console.WriteLine( $"Lines logged: {logger1.LinesLogged}");
        }
    }
}
