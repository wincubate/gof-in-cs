namespace Wincubate.MediatorLabs
{
    abstract class EngineComponent
    {
        public IEngineMediator Mediator { get; protected set; }

        public EngineComponent( IEngineMediator mediator )
        {
            Mediator = mediator;
        }
    }
}
