using System;

namespace Wincubate.MediatorLabs
{
    class EngineMediator : IEngineMediator
    {
        private Accelerator _accelerator;
        private Brake _brake;
        private GearBox _gearBox;
        private Ignition _ignition;

        #region Properties

        public int ActualSpeedKmh
        {
            get => _actualSpeedKmh;
            set
            {
                if( _actualSpeedKmh != value )
                {
                    _actualSpeedKmh = value;

                    Display();
                }
            }
        }
        private int _actualSpeedKmh;

        #endregion

        public EngineMediator()
        {
            _actualSpeedKmh = 0;
        }

        #region Registration

        public void Register( Accelerator accelerator ) => _accelerator = accelerator;
        public void Register( Brake brake ) => _brake = brake;
        public void Register( GearBox gearBox ) => _gearBox = gearBox;
        public void Register( Ignition ignition ) => _ignition = ignition;

        #endregion

        #region Mediation

        public void OnAcceleratorEnabledChanged( bool isEnabled )
        {
            Display();
            //Console.WriteLine($"Auto System {(isEnabled ? "controls" : "does not control")} the accelerator");
        }

        public void OnAcceleratorPressed()
        {
            _brake.IsEnabled = false;

            while( ActualSpeedKmh < _accelerator.TargetSpeedKmh )
            {
                ActualSpeedKmh += 5;

                if( ActualSpeedKmh >= 130 )
                {
                    _gearBox.Gear = Gear.Seventh;
                }
                else if(ActualSpeedKmh >= 110)
                {
                    _gearBox.Gear = Gear.Sixth;
                }
                else if (ActualSpeedKmh >= 90)
                {
                    _gearBox.Gear = Gear.Fifth;
                }
                else if (ActualSpeedKmh >= 70)
                {
                    _gearBox.Gear = Gear.Fourth;
                }
                else if (ActualSpeedKmh >= 50)
                {
                    _gearBox.Gear = Gear.Third;
                }
                else if (ActualSpeedKmh >= 25)
                {
                    _gearBox.Gear = Gear.Second;
                }
                else
                {
                    _gearBox.Gear = Gear.First;
                }
            }
            _brake.IsEnabled = true;
        }

        public void OnBrakePressedChanged( bool isPressed )
        {
            if( isPressed )
            {
                _accelerator.IsEnabled = false;
                _actualSpeedKmh = 0; // Instant brake!
                _gearBox.Gear = Gear.Neutral;
            }
            else
            {
                _gearBox.Gear = Gear.First;
                _accelerator.IsEnabled = true;
            }

            Display();
        }

        public void OnBreakEnabledChanged( bool isEnabled ) => Display();

        public void OnGearBoxEnabledChanged( bool isEnabled ) => Display();
        public void OnGearChanged( Gear newGear ) => Display();

        public void OnIgnitionEnabledChanged( bool isOn )
        {
            _accelerator.IsEnabled = isOn;
            _brake.IsEnabled = isOn;
            _gearBox.IsEnabled = isOn;

            Display();
        }

        #endregion

        #region Display

        private void Display()
        {
            Write(_ignition.IsOn, "Ignition\t");
            Write(_accelerator.IsEnabled, "Acc\t");
            Write(_brake.IsEnabled, "Brake\t");
            Write(true, $"{_gearBox.Gear.ToString()}\t");
            Write(ActualSpeedKmh > 0, $"{ActualSpeedKmh,3} km/h");
            Console.WriteLine();
        }

        private void Write( bool enabled, string s )
        {
            Console.ForegroundColor = (enabled ? ConsoleColor.Blue : ConsoleColor.DarkGray);
            Console.Write( s );
            Console.ResetColor();
        }

        #endregion
    }
}