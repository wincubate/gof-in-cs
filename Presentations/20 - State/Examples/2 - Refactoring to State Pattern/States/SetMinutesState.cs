using System;

namespace Wincubate.StateExamples
{
    class SetMinutesState : TimerSetupStateBase
    {
        private int _timerHours;
        private int _timerMinutes;

        public override (ConsoleColor color, string Text) Display
            => (ConsoleColor.Red, $"{_timerHours:00}:{_timerMinutes:00}");

        public SetMinutesState( TimerSetup context, int timerHours ) : base(context)
        {
            _timerHours = timerHours;
            _timerMinutes = 0;
        }

        public override void OnTimerPressed() => ChangeState(new NormalState(_context));

        public override void OnOkPressed()
        {
            ChangeState(new CompletedState(_context, _timerHours, _timerMinutes));
        }

        public override void OnUpPressed() => _timerMinutes = (++_timerMinutes) % 60;

        public override void OnDownPressed() => _timerMinutes = (--_timerMinutes + 60) % 60;
    }
}
