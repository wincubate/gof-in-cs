using System;

namespace Wincubate.StateExamples
{
    struct CompletedPayload
    {
        public int TimerHours { get; set; }
        public int TimerMinutes { get; set; }
    }

    class CompletedState : TimerSetupStateBase
    {
        public override (ConsoleColor color, string Text) Display
            => (ConsoleColor.Green, TimerSet.ToLongTimeString());

        public DateTime TimerSet { get; }

        public CompletedState(
            TimerSetup context, 
            CompletedPayload payload ) : base(context)
        {
            DateTime now = DateTime.Now;
            TimerSet = new DateTime(
                now.Year,
                now.Month,
                now.Day,
                payload.TimerHours,
                payload.TimerMinutes,
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