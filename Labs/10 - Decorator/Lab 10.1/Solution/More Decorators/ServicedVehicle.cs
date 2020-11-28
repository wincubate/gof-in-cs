using System;
using System.Collections.Generic;
using System.Linq;
using Wincubate.DecoratorExamples;

namespace Wincubate.DecoratorLab
{
    public class ServicedVehicle : VehicleDecorator
    {
        public int NextServiceKm { get; private set; }
        public int ServiceIntervalInKm { get; }

        public IEnumerable<ServiceLogEntry> LogEntries => _logEntries;
        private IList<ServiceLogEntry> _logEntries;

        public override string ToString() => base.ToString() + Environment.NewLine +
            $"{string.Join(string.Empty,_logEntries.Select( entry => $"{entry}{Environment.NewLine}"))}" +
            $"Next Service: {NextServiceKm}"
            ;

        public override void Drive(int km)
        {
            base.Drive(km);
            
            if( KilometersTravelled > NextServiceKm )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine( $"Exceeded next service kilometers by {KilometersTravelled - NextServiceKm} km");
                Console.ResetColor();
            }
        }

        public ServicedVehicle(
            IVehicle decoratee, 
            int serviceIntervalInKm = 20000,
            int nextServiceKm = 20000
        ) : base(decoratee)
        {
            NextServiceKm = nextServiceKm;
            ServiceIntervalInKm = serviceIntervalInKm;

            _logEntries = new List<ServiceLogEntry>();
        }

        public void ServicePerformed(ServiceLogEntry logEntry, int nextServiceKm)
        {
            _logEntries.Add(logEntry);

            NextServiceKm = nextServiceKm;
        }
    }
}