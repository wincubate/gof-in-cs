using System;

namespace Wincubate.MediatorLabs
{
    class GearBox : EngineComponent
    {
        #region Properties

        public Gear Gear
        {
            get => _gear;
            set
            {
                if( _isEnabled && _gear != value )
                {
                    _gear = value;
                    Console.WriteLine( $"Switching gear to {_gear} Gear");

                    Mediator.OnGearChanged(_gear);
                }
            }
        }
        private Gear _gear;

        public bool IsEnabled
        {
            get => _isEnabled;
            set
            {
                if (_isEnabled != value)
                {
                    _isEnabled = value;
                    Console.WriteLine($"Gear box {(_isEnabled ? "enabled" : "disabled")}");

                    Mediator.OnGearBoxEnabledChanged(_isEnabled);
                }
            }
        }
        private bool _isEnabled;

        #endregion

        public GearBox( IEngineMediator mediator ) : base(mediator)
        {
            _isEnabled = false;
            _gear = Gear.Neutral;

            Mediator.Register(this);
        }
    }
}
