using System;

namespace Wincubate.StateExamples
{
    class TimerSetup
    {
        private StateKind _state;
        public DateTime? TimerSet { get; private set; }

        public TimerSetup()
        {
            _state = StateKind.Normal;
        }

        public void ShowDisplay()
        {
            ConsoleColor old = Console.ForegroundColor;

            (ConsoleColor color, string text) = Display;
            Console.ForegroundColor = color;
            Console.WriteLine(text);

            Console.ForegroundColor = old;
        }

        #region State-specific Behavior

        private int _timerHours;
        private int _timerMinutes;

        public (ConsoleColor color, string Text) Display
        {
            get
            {
                switch (_state)
                {
                    case StateKind.Normal:
                        return (ConsoleColor.Gray, DateTime.Now.ToShortTimeString());
                    case StateKind.SetHours:
                        return (ConsoleColor.Red, $"{_timerHours:00}");
                    case StateKind.SetMinutes:
                        return (ConsoleColor.Red, $"{_timerHours:00}:{_timerMinutes:00}");
                    case StateKind.Completed:
                        return (ConsoleColor.Green, TimerSet?.ToLongTimeString());
                    default:
                        throw new NotImplementedException($"State {_state} not expected");
                }
            }
        }

        public void OnTimerPressed()
        {
            switch (_state)
            {
                case StateKind.Normal:
                    _state = StateKind.SetHours;
                    DateTime now = DateTime.Now;

                    _timerHours = now.Hour;
                    _timerMinutes = 0;
                    break;
                case StateKind.SetHours:
                case StateKind.SetMinutes:
                case StateKind.Completed:
                    // Cancel timer setup
                    _state = StateKind.Normal;
                    break;
                default:
                    throw new NotImplementedException($"State {_state} not expected");
            }
        }

        public void OnOkPressed()
        {
            switch (_state)
            {
                case StateKind.Normal:
                    // Do nothing
                    break;
                case StateKind.SetHours:
                    _state = StateKind.SetMinutes;
                    break;
                case StateKind.SetMinutes:
                    _state = StateKind.Completed;
                    DateTime now = DateTime.Now;
                    TimerSet = new DateTime(
                        now.Year,
                        now.Month,
                        now.Day,
                        _timerHours,
                        _timerMinutes,
                        0
                    );
                    break;
                case StateKind.Completed:
                    _state = StateKind.Normal;
                    break;
                default:
                    throw new NotImplementedException($"State {_state} not expected");
            }
        }

        public void OnDownPressed()
        {
            switch (_state)
            {
                case StateKind.Normal:
                case StateKind.Completed:
                    // Do nothing
                    break;
                case StateKind.SetHours:

                    _timerHours = (--_timerHours + 24) % 24;
                    break;
                case StateKind.SetMinutes:
                    _timerMinutes = (--_timerMinutes + 60) % 60;
                    break;
                default:
                    throw new NotImplementedException($"State {_state} not expected");
            }
        }

        public void OnUpPressed()
        {
            switch (_state)
            {
                case StateKind.Normal:
                case StateKind.Completed:
                    // Do nothing
                    break;
                case StateKind.SetHours:
                    _timerHours = (++_timerHours) % 24;
                    break;
                case StateKind.SetMinutes:
                    _timerMinutes = (++_timerMinutes) % 60;
                    break;
                default:
                    throw new NotImplementedException($"State {_state} not expected");
            }
        }

        #endregion
    }
}