using System;
using System.Collections.Generic;
using System.Linq;

namespace Wincubate.DecoratorExamples
{
    public class Rental : VehicleDecorator
    {
        public int Available { get; private set; }

        public IEnumerable<string> RentalHistory => _rentalHistory;
        private List<string> _rentalHistory;

        public override string ToString() =>
            base.ToString() +
            $"{Environment.NewLine}{Available} available for rent." +
            $"{Environment.NewLine}{string.Join(Environment.NewLine, _rentalHistory)}{Environment.NewLine}";

        public Rental( IVehicle decoratee, int available ) : base(decoratee)
        {
            Available = available;

            _rentalHistory = new List<string>();
        }

        public void Rent( string customer )
        {
            if( Available > 0 )
            {
                _rentalHistory.Add($"{DateTime.Now}: Rented by {customer}");
                Available--;
            }
        }

        public void Return()
        {
            _rentalHistory.Add($"{DateTime.Now}: Returned");
            Available++;
        }
    }
}