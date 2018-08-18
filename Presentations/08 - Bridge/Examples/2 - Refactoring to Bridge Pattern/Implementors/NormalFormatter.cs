namespace Wincubate.BridgeExamples
{
    class NormalFormatter : IFormatter
    {
        public string Prepare( string reservation ) => reservation;
    }
}
