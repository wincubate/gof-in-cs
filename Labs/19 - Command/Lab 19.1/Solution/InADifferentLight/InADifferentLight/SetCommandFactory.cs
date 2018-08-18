namespace InADifferentLight
{
    class SetCommandFactory : ISetCommandFactory
    {
        private readonly IUnit[] _units;

        public SetCommandFactory( params IUnit[] units )
        {
            _units = units;
        }

        public ICommand CreateCommand( int index, int intensityPercentage )
        {
            ICommand command = null;

            if( 0 <= index && index < _units.Length )
            {
                return new SetCommand(
                     _units[index],
                    intensityPercentage
                );
            }

            return command;
        }
    }
}
