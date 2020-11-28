namespace Wincubate.DecoratorExamples
{
    public abstract class Vehicle : IVehicle
    {
        public string Make { get; }
        public VehicleColor Color { get; }
        public int KilometersTravelled { get; private set; }

        public override string ToString() => $"\t{Make} [{Color}] (Travelled: {KilometersTravelled} km)";

        public Vehicle( string make, VehicleColor color, int initialKilometers = 0 )
        {
            Make = make;
            Color = color;
            KilometersTravelled = initialKilometers;
        }

        public void Drive( int kilometers)
        {
            KilometersTravelled += kilometers;
        }
    }
}