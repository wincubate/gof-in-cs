using System;
using System.IO;

namespace Wincubate.NullObjectExamples.Logging
{
    public class FileLoggerFactory : ILoggerFactory
    {
        public FileLoggerFactory()
        {
        }

        public ILogger Create( string name ) =>
            new FileLogger(
                Path.Combine(
                    Environment.CurrentDirectory,
                    $"{name}.log"
                    )
                );
    }
}
