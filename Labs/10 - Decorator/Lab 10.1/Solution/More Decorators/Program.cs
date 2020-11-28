using System;
using Wincubate.DecoratorExamples;

namespace Wincubate.DecoratorLab
{
    class Program
    {
        static void Main( string[] args )
        {
            IVehicle bmwX1 = new Car("BMW X1",VehicleColor.Black,CarBodyStyle.Sport,5);
            //IVehicle bmwM2 = new Car("BMW M2",VehicleColor.CobaltBlue,CarBodyStyle.Coupe,5);
            //IVehicle bmwi3 = new Car("BMW i3",VehicleColor.RubyRed,CarBodyStyle.Sedan,5);
            //IVehicle kawasakiNinja400 = new Motorcycle("Kawasaki Ninja 400 2018",VehicleColor.LimeGreen,2,399);
            //IVehicle aprilia = new Motorcycle("Aprilia Shiver 900",VehicleColor.Black,2,896);

            ServicedVehicle servicedBmwX1 = new ServicedVehicle(bmwX1);
            


            // Drive and service
            Console.WriteLine(servicedBmwX1);
            Console.WriteLine($"-------------------------");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine( "Driving...");
            Console.ResetColor();

            servicedBmwX1.Drive(25176);

            Console.WriteLine(servicedBmwX1);
            Console.WriteLine($"-------------------------");

            Workshop workshop = new Workshop();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("At workshop...");
            Console.ResetColor();

            workshop.Service(servicedBmwX1);

            Console.WriteLine(servicedBmwX1);
            Console.WriteLine($"-------------------------");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Driving...");
            Console.ResetColor();

            servicedBmwX1.Drive(12880);

            Console.WriteLine(servicedBmwX1);
            Console.WriteLine($"-------------------------");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("At workshop...");
            Console.ResetColor();

            workshop.Service(servicedBmwX1);
            Console.WriteLine(servicedBmwX1);
            Console.WriteLine($"-------------------------");
        }
    }
}