using System.Threading;

namespace Wincubate.CommandExamples
{
    class TimedSwitch : ISwitch
    {
        private readonly ICommand _command;

        public TimedSwitch( ICommand command ) => _command = command;

        public void Click() 
        {
            ThreadPool.QueueUserWorkItem(_ =>
            {
                // Only for illustrative purposes ;-)
                Thread.Sleep(5000);

                _command.Execute();
            });
        }
    }
}
