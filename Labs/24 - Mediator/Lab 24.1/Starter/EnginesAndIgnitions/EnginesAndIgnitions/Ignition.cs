using System;

namespace Wincubate.MediatorLabs
{
    class Ignition : EngineComponent
    {
        #region Properties

        public bool IsOn { get; private set; }

        #endregion

        public Ignition()
        {
            IsOn = false;
        }

        public void Start()
        {
            IsOn = true;
            Console.WriteLine("Ignition turned on");
        }

        public void Stop()
        {
            IsOn = false;
            Console.WriteLine("Ignition turning off");
        }
    }
}
