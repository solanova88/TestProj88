
public class Plane : Vehicle
{
    protected int passengersCount;

    public Plane(double speed, double fuelConsumption, double gasTankCapacity, string? manufacturer, int passengersCount)
        : base(speed, fuelConsumption, gasTankCapacity, manufacturer)
    {
        this.passengersCount = passengersCount;
        this.Speed = speed - (passengersCount * 0.2);
    }
}
