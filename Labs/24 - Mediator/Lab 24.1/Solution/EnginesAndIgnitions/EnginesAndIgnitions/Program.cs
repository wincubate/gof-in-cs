using System;

namespace Wincubate.MediatorLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            IEngineMediator mediator = new EngineMediator();
            Accelerator accelerator = new Accelerator(mediator);
            Brake brake = new Brake(mediator);
            GearBox gearBox = new GearBox(mediator);
            Ignition ignition = new Ignition(mediator);

            ignition.Start();
            accelerator.SetAccelerationTarget(50);
            brake.Press();
            ignition.Stop();
        }
    }
}
