using System;

namespace Wincubate.ChainOfResponsibilityExamples
{
    class MessageChainHandler : IMessageChainHandler
    {

        private readonly IMessageScreener _screener;
        private IMessageChainHandler _next;

        public MessageChainHandler( IMessageScreener screener ) => _screener = screener;

        public IMessageChainHandler AttachNext( IMessageChainHandler next ) => _next = next;

        public ScreeningResponse? Screen( IMessage message )
        {
            ScreeningResponse? response = _screener.Screen(message);

            if (response.HasValue == false)
            {
                return _next?.Screen(message);
            }
            else
            {
                Console.WriteLine($"Handled by {_screener.GetType().Name}");
                return response;
            }
        }
    }
}
