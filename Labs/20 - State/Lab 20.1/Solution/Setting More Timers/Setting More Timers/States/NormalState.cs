using System;

namespace SettingMoreTimers
{
    class NormalState : TimerSetupStateBase
    {
        public NormalState( TimerSetup context ) : base(context)
        {
        }

        public override (ConsoleColor color, string Text) Display
            => (ConsoleColor.Gray, DateTime.Now.ToShortTimeString());

        public override void OnTimerPressed() =>  ChangeState(new SetHoursState(_context));
    }
}
