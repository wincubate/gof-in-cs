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
                if (_actualSpeedKmh != value)
                {
                    _actualSpeedKmh = value;

                    Display();
                }
            }
        }
        private int _actualSpeedKmh;

        // TODO

        #endregion

        public EngineMediator()
        {
        }

        #region Registration

        // TODO

        #endregion

        #region Mediation

        // TODO

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
            Console.Write(s);
            Console.ResetColor();
        }

        #endregion
    }
}