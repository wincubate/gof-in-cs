using System;
using System.Collections.Generic;
using System.Linq;

namespace Wincubate.BridgeExamples
{
    class FlightReservation : Reservation
    {
        public string PassengerName { get; set; }
        public IEnumerable<Leg> Legs { get; set; }

        public FlightReservation( IFormatter formatter ) : base(formatter)
        {
        }

        public override string ToString() => _formatter.Prepare(
            $"Passenger: {PassengerName}" + Environment.NewLine +
            "Legs: " + string.Join(", ", Legs.Select(leg => leg.ToString())) + Environment.NewLine +
            When
        );
    }

    class Leg
    {
        public string From { get; set; }
        public string To { get; set; }

        public override string ToString() => $"{From}->{To}";
    }
}
