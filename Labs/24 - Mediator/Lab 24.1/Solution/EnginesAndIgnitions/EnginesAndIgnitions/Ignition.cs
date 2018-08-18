using System;

namespace Wincubate.MediatorLabs
{
    class Ignition : EngineComponent
    {
        #region Properties

        public bool IsOn { get; private set; }

        #endregion

        public Ignition( IEngineMediator mediator ) : base(mediator)
        {
            IsOn = false;

            Mediator.Register(this);
        }

        public void Start()
        {
            IsOn = true;
            Console.WriteLine("Ignition turned on");

            Mediator.OnIgnitionEnabledChanged(IsOn);
        }

        public void Stop()
        {
            IsOn = false;
            Console.WriteLine("Ignition turning off");

            Mediator.OnIgnitionEnabledChanged(IsOn);
        }
    }
}
