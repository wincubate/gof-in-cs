using Wincubate.CommandExamples.Hardware;

namespace Wincubate.CommandExamples
{
    class ToggleCommand : ICommand
    {
        private readonly IToggleable _toggleable;

        public ToggleCommand( IToggleable toggleable ) => _toggleable = toggleable;

        public void Execute() => _toggleable.Toggle();
    }
}
