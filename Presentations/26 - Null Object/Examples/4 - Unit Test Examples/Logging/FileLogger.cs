using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Wincubate.NullObjectExamples.Logging
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger( string path )
        {
            _path = path;
        }

        public void Enter( [CallerMemberName] string callerMemberName = null )
        {
            string line = $"{DateTime.Now}:\tEntering {callerMemberName}{Environment.NewLine}";
            File.AppendAllText( _path, line );
        }

        public void Exit( [CallerMemberName] string callerMemberName = null )
        {
            string line = $"{DateTime.Now}:\tExiting {callerMemberName}{Environment.NewLine}";
            File.AppendAllText(_path, line);
        }

        public void Info( string message )
            => Log(message, false);

        public void Info( Exception exception )
            => Log(exception.ToString(), false);

        public void Error( string message )
            => Log(message, true);

        public void Error( Exception exception )
            => Log(exception.ToString(), true);

        private void Log( string message, bool isError )
        {
            string line = $"{DateTime.Now}:\t{( isError ? "Error" : "Info ")}\t{message}{Environment.NewLine}";
            File.AppendAllText(_path, line);
        }
    }
}