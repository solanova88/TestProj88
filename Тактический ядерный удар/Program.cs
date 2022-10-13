
using Тактический_ядерный_удар;

try
{
	
	List<Vehicle> vehicles = new List<Vehicle>
	{
		new Truck(100, 25, 500, "Scania"),
		new MotorCar(200, 15, 75, "Kia"),
		new Motorcycle(350, 9, 30, "Honda"),
        new Plane(1000, 2500, 10000, "Cessna", 20)
    };

	Console.WriteLine(TripHelper.GetProfitableVehicleIndex(vehicles, 100));
}
catch (Exception ex)
{
	Console.WriteLine($"Ошибка: {ex.Message}");
}
