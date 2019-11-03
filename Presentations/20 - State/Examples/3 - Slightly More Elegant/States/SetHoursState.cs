using System;

namespace Wincubate.StateExamples
{
    class SetHoursState : TimerSetupStateBase
    {

        private int _timerHours;

        public SetHoursState( TimerSetup context ) : base(context)
        {
            DateTime now = DateTime.Now;
            _timerHours = now.Hour;
        }

        public override (ConsoleColor color, string Text) Display
            => (ConsoleColor.Red, $"{_timerHours:00}");

        public override void OnTimerPressed() => ChangeState(new NormalState(_context));

        public override void OnOkPressed()
            => ChangeState(new SetMinutesState(
                _context, 
                new SetMinutesPayload
                {
                    TimerHours = _timerHours
                }));

        public override void OnUpPressed() => _timerHours = (++_timerHours) % 24;

        public override void OnDownPressed() => _timerHours = (--_timerHours + 24) % 24;
    }
}