using System.Collections.Generic;

namespace InADifferentLight
{
    class LoggingSwitch
    {
        private readonly IList<ICommand> _commandsExecuted;

        public LoggingSwitch()
        {
            _commandsExecuted = new List<ICommand>();
        }

        public void Execute( ICommand command )
        {
            _commandsExecuted.Add(command);
            command.Execute();
        }
    }
}
