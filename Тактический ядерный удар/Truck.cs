
public class Truck : Vehicle
{
	public Truck(double speed, double fuelConsumption, double gasTankCapacity, string? manufacturer)
	  : base(speed, fuelConsumption, gasTankCapacity, manufacturer)
	{
		if (speed >= 120)
			throw new Exception("максимальная скорость грузовика 120 км/ч");
	}
}
