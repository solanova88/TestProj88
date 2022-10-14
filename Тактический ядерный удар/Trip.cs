using System.Xml.Serialization;

namespace Тактический_ядерный_удар
{
    public class Trip
    {
        public TimeSpan Time;
        public double ConsumedFuel;
        public double DistanceInMeters;
        public Vehicle Vehicle;
        string? vehTitle;
        public Trip(TimeSpan time, double consumedFuel, double distanceInMeters, Vehicle vehicle)
        {
            Time = time;
            ConsumedFuel = consumedFuel;
            DistanceInMeters = distanceInMeters;
            Vehicle = vehicle;
        }



        public override string ToString()
        {
            if (Vehicle is Truck)
                vehTitle = "Грузовик";
            else if (Vehicle is MotorCar)
                vehTitle = "Легковой автомобиль";
            else if (Vehicle is Motorcycle)
                vehTitle = "Мотоцикл";
            else if (Vehicle is Plane)
                vehTitle = "Самолет";

            return $"Затрачено времени: {Time}, Израсходовано топлива: {ConsumedFuel}л, Пройдено расстояния: {DistanceInMeters}м, Вид транспортного средства: {vehTitle}";

        }
    }
}
