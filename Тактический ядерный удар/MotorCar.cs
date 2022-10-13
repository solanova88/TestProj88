
public class MotorCar : Vehicle
{
	public MotorCar(double speed, double fuelConsumption, double gasTankCapacity, string? manufacturer)
		: base(speed, fuelConsumption, gasTankCapacity, manufacturer)
	{
		if (speed >= 250)
			throw new Exception("максимальная скорость автомобиля 250 км/ч");
	}
}
