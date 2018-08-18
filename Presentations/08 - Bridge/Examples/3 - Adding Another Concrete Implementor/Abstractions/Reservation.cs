using System;

namespace Wincubate.BridgeExamples
{
    abstract class Reservation
    {
        protected readonly IFormatter _formatter;

        public DateTime When { get; set; }

        public Reservation( IFormatter formatter )
        {
            _formatter = formatter;
        }
    }
}
