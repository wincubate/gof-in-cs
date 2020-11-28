namespace Wincubate.DecoratorLab
{
    public struct ServiceLogEntry
    {
        public int KmTravelledAtService { get; }
        public string Mechanic { get; }

        public override string ToString() =>
            $"Serviced at {KmTravelledAtService} km by {Mechanic}";

        public ServiceLogEntry( int kilometersTravelled, string mechanic )
        {
            KmTravelledAtService = kilometersTravelled;
            Mechanic = mechanic;
        }
    }
}