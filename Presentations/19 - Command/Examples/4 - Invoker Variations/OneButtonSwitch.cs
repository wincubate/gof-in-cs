namespace Wincubate.CommandExamples
{
    class OneButtonSwitch : ISwitch
    {
        private readonly ICommand _command;

        public OneButtonSwitch( ICommand command ) => _command = command;

        public void Click() => _command.Execute();
    }
}
