namespace Wincubate.ChainOfResponsibilityExamples
{
    class CustomerServiceScreener : IMessageScreener
    {
        public ScreeningResponse? Screen( IMessage message ) => ScreeningResponse.Accepted;
    }
}
