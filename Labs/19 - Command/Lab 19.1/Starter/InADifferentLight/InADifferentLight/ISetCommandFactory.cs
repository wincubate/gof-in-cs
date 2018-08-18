namespace InADifferentLight
{
    interface ISetCommandFactory
    {
        ICommand CreateCommand( int index, int intensityPercentage );
    }
}
