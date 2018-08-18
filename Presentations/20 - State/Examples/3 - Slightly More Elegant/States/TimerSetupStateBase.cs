using System;

namespace Wincubate.StateExamples
{
    abstract class TimerSetupStateBase : ITimerSetupState
    {
        protected readonly TimerSetup _context;

        public TimerSetupStateBase( TimerSetup context ) => _context = context;

        #region ITimerSetup Members

        public abstract (ConsoleColor color, string Text) Display { get; }

        public virtual void OnDownPressed()
        {
        }

        public virtual void OnOkPressed()
        {
        }

        public virtual void OnTimerPressed()
        {
        }

        public virtual void OnUpPressed()
        {
        }

        #endregion

        protected void ChangeState( ITimerSetupState newState ) => _context.State = newState;
    }
}
