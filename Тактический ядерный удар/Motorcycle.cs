
public class Motorcycle : Vehicle
{
	public Motorcycle(double speed, double fuelConsumption, double gasTankCapacity, string? manufacturer)
		: base(speed, fuelConsumption, gasTankCapacity, manufacturer)
	{
		if (speed >= 300)
			throw new Exception("максимальная скорость мотоцикла 300 км/ч");
	}
}
