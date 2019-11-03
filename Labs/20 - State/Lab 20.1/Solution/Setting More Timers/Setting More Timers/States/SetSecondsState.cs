using System;

namespace SettingMoreTimers
{
    struct SetSecondsPayload
    {
        public int TimerHours { get; set; }
        public int TimerMinutes { get; set; }
    }

    class SetSecondsState : TimerSetupStateBase
    {
        private SetSecondsPayload _payload;
        private int _timerSeconds;

        public override (ConsoleColor color, string Text) Display
            => (ConsoleColor.Red, $"{_payload.TimerHours:00}:{_payload.TimerMinutes:00}:{_timerSeconds:00}");

        public SetSecondsState( TimerSetup context, SetSecondsPayload payload ) : base(context)
        {
            _payload = payload;
            _timerSeconds = 0;
        }

        public override void OnTimerPressed() => ChangeState(new NormalState(_context));

        public override void OnOkPressed()
        {
            ChangeState(new CompletedState(
                _context,
                new CompletedPayload
                {
                    TimerHours = _payload.TimerHours,
                    TimerMinutes = _payload.TimerMinutes,
                    TimerSeconds = _timerSeconds
                }));
        }

        public override void OnUpPressed() => _timerSeconds = (++_timerSeconds) % 60;

        public override void OnDownPressed() => _timerSeconds = (--_timerSeconds + 60) % 60;
    }
}
