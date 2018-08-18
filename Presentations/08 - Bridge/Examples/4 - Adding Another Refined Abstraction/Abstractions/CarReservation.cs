using System;

namespace Wincubate.BridgeExamples
{
    class CarReservation : Reservation
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int MaxMileage { get; set; }

        public CarReservation( IFormatter formatter ) : base(formatter)
        {
        }

        public override string ToString() => _formatter.Prepare(
            $"{Make} {Model} (Mileage: {MaxMileage})" + Environment.NewLine +
            When
        );
    }
}
