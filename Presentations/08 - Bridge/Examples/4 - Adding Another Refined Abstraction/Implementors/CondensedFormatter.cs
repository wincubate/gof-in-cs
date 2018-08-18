using System;

namespace Wincubate.BridgeExamples
{
    class CondensedFormatter : IFormatter
    {
        public string Prepare( string reservation ) =>
            reservation.Replace(Environment.NewLine, " // ");
    }
}
