namespace Wincubate.ChainOfResponsibilityExamples
{
    interface IMessageScreener
    {
        ScreeningResponse? Screen( IMessage message );
    }
}
