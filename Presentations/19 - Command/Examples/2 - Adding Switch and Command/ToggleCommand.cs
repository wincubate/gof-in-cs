using Wincubate.CommandExamples.Hardware;

namespace Wincubate.CommandExamples
{
    class ToggleCommand : ICommand
    {
        private readonly Light _light;

        public ToggleCommand( Light light ) => _light = light;

        public void Execute() => _light.Toggle();
    }
}
