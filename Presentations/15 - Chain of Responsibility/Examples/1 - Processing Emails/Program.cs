using System;
using System.Collections.Generic;

namespace Wincubate.ChainOfResponsibilityExamples
{
    class Program
    {
        static void Main( string[] args )
        {
            IEnumerable<IMessageScreener> screeners = new List<IMessageScreener>
            {
                new SpamScreener(),
                new HRScreener(),
                new AccountingScreener(),
                new SalesScreener()
            };

            IMessage message = new EmailMessage
            {
                Subject = "Invoice problem",
                Body = "I have not yet received an invoice"
            };

            //IMessage message = new EmailMessage
            //{
            //    Subject = "Enlarge your penis",
            //    Body = "... and get rich fast!"
            //};

            //IMessage message = new EmailMessage
            //{
            //    Subject = "Well done",
            //    Body = "I like your company"
            //};

            bool wasProcessed = false;
            foreach (IMessageScreener screener in screeners)
            {
                ScreeningResponse? response = screener.Screen(message);
                if( response.HasValue)
                {
                    Console.WriteLine( $"Message was {response} by {screener.GetType().Name}");
                    wasProcessed = true;
                    break;
                }
            }

            if( wasProcessed == false)
            {
                Console.WriteLine( "Message was not processed");
            }
        }
    }
}
