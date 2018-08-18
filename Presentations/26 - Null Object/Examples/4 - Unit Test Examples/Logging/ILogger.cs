using System;
using System.Runtime.CompilerServices;

namespace Wincubate.NullObjectExamples.Logging
{
    public interface ILogger
    {
        void Enter( [CallerMemberName] string callerMemberName = null );
        void Exit( [CallerMemberName] string callerMemberName = null );

        void Info( string message );
        void Info( Exception exception );

        void Error( string message );
        void Error( Exception exception );
    }
}