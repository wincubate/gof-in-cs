using System;

namespace Wincubate.ChainOfResponsibilityExamples
{
    class EmailMessage : IMessage
    {
        public string Subject { get; set; }
        public string Body { get; set; }

        public string Contents => $"{Subject}{Environment.NewLine}{Body}";
    }
}
