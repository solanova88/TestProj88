
using Тактический_ядерный_удар;

try
{

	List<Vehicle> vehicles = new List<Vehicle>
	{
		new Truck(100, 25, 500, "Scania"),
		new MotorCar(200, 15, 75, "Kia"),
		new Motorcycle(290, 9, 30, "Honda"),
        new Plane(1000, 2500, 10000, "Cessna", 20)
    };
	Truck truck = new Truck(100, 25, 500, "Scania");
	Console.WriteLine(truck.MoveToDistance(0.2));
	Plane plane = new Plane(1000, 2500, 10000, "Cessna", 20);
	Console.WriteLine(plane.MoveToDistance(1));

   // Console.WriteLine($"Наиболее выгодное транспортное средство: {TripHelper.GetProfitableVehicleIndex(vehicles, 0.1)}");
}
catch (Exception ex)
{
	Console.WriteLine($"Ошибка: {ex.Message}");
}
