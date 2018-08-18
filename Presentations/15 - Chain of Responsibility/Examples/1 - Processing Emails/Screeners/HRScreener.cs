namespace Wincubate.ChainOfResponsibilityExamples
{
    class HRScreener : IMessageScreener
    {
        public ScreeningResponse Screen( IMessage message ) =>
            message.Contents.ContainsAnyOf("job", "application", "cv") ?
                ScreeningResponse.Accepted :
                ScreeningResponse.Unprocessed;
    }
}
