using System;

namespace Wincubate.BridgeExamples
{
    class EventTicket : Reservation
    {
        public string EventName { get; set; }
        public string Venue { get; set; }
        public string Seat { get; set; }

        public EventTicket( IFormatter formatter ) : base( formatter )
        {

        }
        public override string ToString() => _formatter.Prepare(
            EventName + Environment.NewLine +
            $"Venue: {Venue}" + Environment.NewLine +
            When + Environment.NewLine +
            $"Seat: {Seat}"
        );
    }
}
