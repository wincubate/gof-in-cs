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
                }
            }
        }
        private bool _isEnabled;

        public bool IsPressed => _isPressed;
        private bool _isPressed;

        #endregion

        public Brake()
        {
            _isEnabled = true;
            _isPressed = true;    
        }

        public void Press()
        {
            if( IsEnabled )
            {
                _isPressed = true;
                Console.WriteLine("Braking...");
            }
        }

        public void Release()
        {
            if( IsEnabled )
            {
                _isPressed = false;
                Console.WriteLine("Releasing brake...");
            }
        }
    }
}