using System;

namespace SettingMoreTimers
{
    interface ITimerSetupState
    {
        (ConsoleColor color, string Text) Display { get; }
        void OnTimerPressed();
        void OnOkPressed();
        void OnUpPressed();
        void OnDownPressed();
    }
}
