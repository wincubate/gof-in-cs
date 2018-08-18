namespace Wincubate.ChainOfResponsibilityExamples
{
    interface IMessageChainHandler : IMessageScreener
    {
        IMessageChainHandler AttachNext( IMessageChainHandler next );
    }
}