namespace Wincubate.DecoratorExamples
{
    public interface IVehicle
    {
        string Make { get; }
        VehicleColor Color { get; }
        int KilometersTravelled { get; }

        void Drive(int kilometers);
    }
}
