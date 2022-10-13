

using System;

namespace Тактический_ядерный_удар
{
    public static class TripHelper 
    {

       public static int GetProfitableVehicleIndex(List<Vehicle> vehicles, double distanceInKilometers)
        {
            int index = 0;
            double currentProfitValue = double.MaxValue;
            foreach (Vehicle vehicle in vehicles)
            {
                double time = distanceInKilometers / vehicle.Speed;
                double consumedFuel = vehicle.FuelConsumption / 100 * distanceInKilometers;
                double profitValue = time * 1.2 + consumedFuel;
                if (profitValue < currentProfitValue)
                {
                    index = vehicles.IndexOf(vehicle);
                    currentProfitValue = profitValue;
                    
                }
            }
            return index;

        }

    }
}
