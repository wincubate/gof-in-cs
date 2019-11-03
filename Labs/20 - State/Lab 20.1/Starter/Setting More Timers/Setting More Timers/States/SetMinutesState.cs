using System;

namespace SettingMoreTimers
{
    struct SetMinutesPayload
    {
        public int TimerHours { get; set; }
    }

    class SetMinutesState : TimerSetupStateBase
    {
        private SetMinutesPayload _payload;
        private int _timerMinutes;

        public override (ConsoleColor color, string Text) Display
            => (ConsoleColor.Red, $"{_payload.TimerHours:00}:{_timerMinutes:00}");

        public SetMinutesState( TimerSetup context, SetMinutesPayload payload ) : base(context)
        {
            _payload = payload;
            _timerMinutes = 0;
        }

        public override void OnTimerPressed() => ChangeState(new NormalState(_context));

        public override void OnOkPressed()
        {
            ChangeState(new CompletedState(
                _context,
                new CompletedPayload
                {
                    TimerHours = _payload.TimerHours,
                    TimerMinutes = _timerMinutes
                }));
        }

        public override void OnUpPressed() => _timerMinutes = (++_timerMinutes) % 60;

        public override void OnDownPressed() => _timerMinutes = (--_timerMinutes + 60) % 60;
    }
}
