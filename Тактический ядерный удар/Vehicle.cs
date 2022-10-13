using Тактический_ядерный_удар;

public abstract class Vehicle : IMovable
{
	public double Speed { get; protected set; }
	public double FuelConsumption { get; private set; }
	public double GasTankCapacity { get; private set; }
	public string? Manufacturer { get; private set; }

	public Vehicle(double speed, double fuelConsumption, double gasTankCapacity, string? manufacturer)
	{
		this.Speed = speed;
		this.FuelConsumption = fuelConsumption;
		this.GasTankCapacity = gasTankCapacity;
		this.Manufacturer = manufacturer;
	}

	public Trip MoveToDistance(double distanceInKilometers, Vehicle vehicle)
	{
		double time = distanceInKilometers / Speed;
		double consumedFuel = FuelConsumption / 100 * distanceInKilometers;
		double maxDistanceInKilometers = GasTankCapacity * 100 / FuelConsumption;

		if (maxDistanceInKilometers < distanceInKilometers)
			Thread.Sleep(Convert.ToInt32(maxDistanceInKilometers / Speed * 3600000));
		else
			Thread.Sleep(Convert.ToInt32(time * 3600000));
        
        Trip trip = new Trip(TimeSpan.FromHours(time), consumedFuel, distanceInKilometers * 1000, vehicle);
        Console.WriteLine(trip.ToString());
        return trip;
    }
}
