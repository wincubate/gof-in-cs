using System;

namespace Wincubate.DecoratorExamples
{
    class Program
    {
        static void Main( string[] args )
        {
            IVehicle bmwX1 = new Car("BMW X1",VehicleColor.Black,CarBodyStyle.Sport,5);
            IVehicle bmwM2 = new Car("BMW M2",VehicleColor.CobaltBlue,CarBodyStyle.Coupe,5);
            IVehicle bmwi3 = new Car("BMW i3",VehicleColor.RubyRed,CarBodyStyle.Sedan,5);
            IVehicle kawasakiNinja400 = new Motorcycle("Kawasaki Ninja 400 2018",VehicleColor.LimeGreen,2,399);
            IVehicle aprilia = new Motorcycle("Aprilia Shiver 900",VehicleColor.Black,2,896);

            Rental rentalBmwX1 = new Rental(bmwX1, 2);
            Rental rentalBmwM2 = new Rental(bmwM2, 3);
            Rental rentalBmwi3 = new Rental(bmwi3, 7);
            Rental rentalKawasakiNinja400 = new Rental(kawasakiNinja400, 3);
            Rental rentalAprilia = new Rental(aprilia, 2);

            // Rent and return
            Console.WriteLine(rentalBmwX1);
            Console.WriteLine($"{Environment.NewLine}-------------------------{Environment.NewLine}");

            rentalBmwX1.Rent("Thorkild Thyrring");

            Console.WriteLine(rentalBmwX1);
            Console.WriteLine($"{Environment.NewLine}-------------------------{Environment.NewLine}");

            rentalBmwX1.Return();

            Console.WriteLine(rentalBmwX1);
            Console.WriteLine($"{Environment.NewLine}-------------------------{Environment.NewLine}");

            //IEnumerable<IVehicle> vehicles = new List<IVehicle>
            //{
            //    rentalBmwX1,
            //    rentalBmwM2,
            //    rentalBmwi3,
            //    rentalKawasakiNinja400,
            //    rentalAsprilia
            //};
            //foreach (IVehicle vehicle in vehicles)
            //{
            //    Console.WriteLine(vehicle);
            //    Console.WriteLine($"{Environment.NewLine}-------------------------{Environment.NewLine}");
            //}
        }
    }
}