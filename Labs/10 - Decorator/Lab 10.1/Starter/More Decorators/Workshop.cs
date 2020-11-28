namespace Wincubate.DecoratorLab
{
    public class Workshop
    {
        public void Service(ServicedVehicle servicedVehicle)
        {
            ServiceLogEntry logEntry = new ServiceLogEntry
            (
                servicedVehicle.KilometersTravelled,
                "Mike Megamotor"
            );

            int nextServiceKilometers = servicedVehicle.NextServiceKm
                + servicedVehicle.ServiceIntervalInKm;

            servicedVehicle.ServicePerformed(logEntry, nextServiceKilometers);
        }
    }
}