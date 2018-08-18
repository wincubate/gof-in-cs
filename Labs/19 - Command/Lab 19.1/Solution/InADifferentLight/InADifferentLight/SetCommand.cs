namespace InADifferentLight
{
    class SetCommand : ICommand
    {
        public IUnit Unit { get; set; }
        public int NewIntensity { get; set; }

        public SetCommand( IUnit unit, int newIntensity )
        {
            Unit = unit;
            NewIntensity = newIntensity;
        }

        public void Execute()
        {
            Unit.SetIntensity(NewIntensity);
        }
    }
}
