using System;

namespace Wincubate.MediatorLabs
{
    class Brake : EngineComponent
    {
        #region Properties

        public bool IsEnabled
        {
            get => _isEnabled;
            set
            {
                if (_isEnabled != value)
                {
                    _isEnabled = value;
                    Console.WriteLine($"Brake {(_isEnabled ? "enabled" : "disabled")}");

                    Mediator.OnBreakEnabledChanged(_isEnabled);
                }
            }
        }
        private bool _isEnabled;

        public bool IsPressed => _isPressed;
        private bool _isPressed;

        #endregion

        public Brake( IEngineMediator mediator ) : base(mediator)
        {
            _isEnabled = true;
            _isPressed = true;    

            Mediator.Register(this);
        }

        public void Press()
        {
            if( IsEnabled )
            {
                _isPressed = true;
                Console.WriteLine("Braking...");

                Mediator.OnBrakePressedChanged( true );
            }
        }

        public void Release()
        {
            if( IsEnabled )
            {
                _isPressed = false;
                Console.WriteLine("Releasing brake...");

                Mediator.OnBrakePressedChanged(false);
            }
        }
    }
}
