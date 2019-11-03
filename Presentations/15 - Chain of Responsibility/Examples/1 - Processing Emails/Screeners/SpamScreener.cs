namespace Wincubate.ChainOfResponsibilityExamples
{
    class SpamScreener : IMessageScreener
    {
        public ScreeningResponse? Screen( IMessage message ) =>
            message.Contents.ContainsAnyOf("viagra", "penis", "$$$") ?
                ScreeningResponse.Rejected :
                default(ScreeningResponse?);
    }
}