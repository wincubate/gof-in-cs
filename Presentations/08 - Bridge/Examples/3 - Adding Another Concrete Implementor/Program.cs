using System;
using System.Collections.Generic;

namespace Wincubate.BridgeExamples
{
    class Program
    {
        static void Main( string[] args )
        {
            IFormatter formatter = new CondensedFormatter();

            IEnumerable<Reservation> reservations = new List<Reservation>
            {
                new EventTicket( formatter )
                {
                    EventName = "Barcelona - Real Madrid",
                    Venue = "Camp Nou",
                    Seat = "Boca 0413, Row 0001, Seat 0016",
                    When = new DateTime(2018, 03, 17, 21, 0, 0)
                },
                new FlightReservation( formatter )
                {
                    PassengerName = "Bruce Campbell",
                    Legs = new List<Leg>
                    {
                        new Leg { From = "BLL", To = "CPH"},
                        new Leg { From = "CPH", To = "MCO"}
                    },
                    When = DateTime.Now
                }
            };

            foreach (Reservation reservation in reservations)
            {
                Console.WriteLine(reservation);
                Console.WriteLine();
            }
        }
    }
}
