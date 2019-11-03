namespace Wincubate.ChainOfResponsibilityExamples
{
    class AccountingScreener : IMessageScreener
    {
        public ScreeningResponse? Screen( IMessage message ) =>
            message.Contents.ContainsAnyOf("invoice", "payment") ?
                ScreeningResponse.Accepted :
                default(ScreeningResponse?);
    }
}
