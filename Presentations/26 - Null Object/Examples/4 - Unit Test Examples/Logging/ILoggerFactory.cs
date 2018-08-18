namespace Wincubate.NullObjectExamples.Logging
{
    public interface ILoggerFactory
    {
        ILogger Create( string name );
    }
}
