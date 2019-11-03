namespace Wincubate.ChainOfResponsibilityExamples
{
    class SalesScreener : IMessageScreener
    {
        public ScreeningResponse? Screen( IMessage message ) =>
            message.Contents.ContainsAnyOf("order", "purchase", "buy") ?
                ScreeningResponse.Accepted :
                default(ScreeningResponse?);
    }
}
