using System;

namespace WritingConsoleLogs
{
    class ConsoleLogger
    {
        public int LinesLogged { get; private set; }

        public ConsoleLogger()
        {
            LinesLogged = 0;
        }

        public void Log( string line, bool error = false )
        {
            // Save existing color
            ConsoleColor old = Console.ForegroundColor;

            Console.ForegroundColor = (error ? ConsoleColor.Red : ConsoleColor.Gray);
            Console.WriteLine( line );

            // Restore previous color
            Console.ForegroundColor = old;

            LinesLogged++;
        }
    }
}
