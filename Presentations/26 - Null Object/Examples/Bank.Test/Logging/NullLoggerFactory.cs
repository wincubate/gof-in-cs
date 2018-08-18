using System;
using Wincubate.NullObjectExamples.Logging;

namespace Wincubate.NullObjectExamples.Test.Logging
{
    public class NullLoggerFactory : ILoggerFactory
    {
        public static ILogger Null
        {
            get => _nullLogger;
        }

        #region Null Object

        private readonly static ILogger _nullLogger = new NullLogger();

        private class NullLogger : ILogger
        {
            public void Enter( string callerMemberName ) { }
            public void Error( string message ) { }
            public void Error( Exception exception ) { }
            public void Exit( string callerMemberName = null ) { }
            public void Info( string message ) { }
            public void Info( Exception exception ) { }
        }

        #endregion

        public ILogger Create( string name ) => Null;
    }
}
