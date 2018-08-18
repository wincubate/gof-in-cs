using System;

namespace Wincubate.StateExamples
{
    class TimerSetup
    {
        internal ITimerSetupState State { get; set; }
        public DateTime? TimerSet { get; internal set; }

        public TimerSetup()
        {
            State = new NormalState( this );
        }

        public void ShowDisplay()
        {
            ConsoleColor old = Console.ForegroundColor;

            (ConsoleColor color, string text) = State.Display;
            Console.ForegroundColor = color;
            Console.WriteLine(text);

            Console.ForegroundColor = old;
        }

        public void OnTimerPressed() => State.OnTimerPressed();
        public void OnOkPressed() => State.OnOkPressed();
        public void OnDownPressed() => State.OnDownPressed();
        public void OnUpPressed() => State.OnUpPressed();
    }
}