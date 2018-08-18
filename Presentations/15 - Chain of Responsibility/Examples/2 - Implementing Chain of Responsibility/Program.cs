using System;

namespace Wincubate.ChainOfResponsibilityExamples
{
    class Program
    {
        static void Main( string[] args )
        {
            IMessageChainHandler spam = new MessageChainHandler(new SpamScreener());
            IMessageChainHandler hr = spam.AttachNext(
                new MessageChainHandler(new HRScreener())
            );
            IMessageChainHandler accounting = hr.AttachNext(
                new MessageChainHandler(new AccountingScreener())
            );
            IMessageChainHandler sales = accounting.AttachNext(
                new MessageChainHandler(new SalesScreener())
            );
            //IMessageChainHandler customerService = sales.AttachNext(
            //    new MessageChainHandler(new CustomerServiceScreener())
            //);

            //IMessage message = new EmailMessage
            //{
            //    Subject = "Invoice problem",
            //    Body = "I have not yet received an invoice"
            //};

            //IMessage message = new EmailMessage
            //{
            //    Subject = "Enlarge your penis",
            //    Body = "... and get rich fast!"
            //};

            IMessage message = new EmailMessage
            {
                Subject = "Well done",
                Body = "I like your company"
            };

            Console.WriteLine($"Message was {spam.Screen(message)}");
        }
    }
}
