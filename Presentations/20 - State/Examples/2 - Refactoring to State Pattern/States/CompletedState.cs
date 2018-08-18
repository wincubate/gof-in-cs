using System;

namespace Wincubate.StateExamples
{
    class CompletedState : TimerSetupStateBase
    {
        public override (ConsoleColor color, string Text) Display
            => (ConsoleColor.Green, TimerSet.ToLongTimeString());

        public DateTime TimerSet { get; }

        public CompletedState( TimerSetup context, int timerHours, int timerMinutes ) : base(context)
        {
            DateTime now = DateTime.Now;
            TimerSet = new DateTime(
                now.Year,
                now.Month,
                now.Day,
                timerHours,
                timerMinutes,
                0
            );
        }

        public override void OnTimerPressed() => ChangeState(new NormalState(_context));

        public override void OnOkPressed()
        {
            _context.TimerSet = TimerSet;
            ChangeState(new NormalState(_context));
        }
    }
}