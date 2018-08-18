using System;

namespace WritingConsoleLogs
{
    sealed class ConsoleLogger
    {
        private object _sync;

        public int LinesLogged
        {
            get
            {
                // Provide thread-safe access to the _linesLogged member while reading
                lock (_sync)
                {
                    return _linesLogged;
                }
            }
        }
        private int _linesLogged;

        private ConsoleLogger()
        {
            _sync = new object();
            _linesLogged = 0;
        }

        public void Log( string line, bool error = false )
        {
            lock (_sync)
            {
                // Save existing color
                ConsoleColor old = Console.ForegroundColor;

                Console.ForegroundColor = (error ? ConsoleColor.Red : ConsoleColor.Gray);
                Console.WriteLine( line );

                // Restore previous color
                Console.ForegroundColor = old;

                // Provide thread-safe access to the _linesLogged member while incrementing
                _linesLogged++;
            }
        }

        #region Singleton Pattern

        public static ConsoleLogger Instance => _lazyInstance.Value;

        private static readonly Lazy<ConsoleLogger> _lazyInstance
            = new Lazy<ConsoleLogger>(() => new ConsoleLogger());

        #endregion
    }
}