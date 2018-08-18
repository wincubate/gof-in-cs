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
                }
            }
        }
        private bool _isEnabled;

        #endregion

        public GearBox()
        {
            _isEnabled = false;
            _gear = Gear.Neutral;
        }
    }
}
