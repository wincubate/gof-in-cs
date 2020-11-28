using Wincubate.DecoratorExamples;

namespace Wincubate.DecoratorLab
{
    public abstract class VehicleDecorator : IVehicle
    {
        protected readonly IVehicle _decoratee;

        public virtual string Make => _decoratee.Make;
        public virtual VehicleColor Color => _decoratee.Color;
        public virtual int KilometersTravelled => _decoratee.KilometersTravelled;

        public override string ToString() => _decoratee.ToString();

        public VehicleDecorator( IVehicle decoratee )
        {
            _decoratee = decoratee;
        }

        public virtual void Drive(int kilometers) => _decoratee.Drive(kilometers);
    }
}
