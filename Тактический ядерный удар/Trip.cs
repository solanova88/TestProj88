using System.Xml.Serialization;

namespace Тактический_ядерный_удар
{
    public class Trip
    {
        public TimeSpan Time;
        public double ConsumedFuel;
        public double DistanceInMeters;
        public object Vehicle;

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
            {
                return $"Время в пути: {Time}, Потрачено топлива: {ConsumedFuel}л, Расстояние поездки: {DistanceInMeters}м, Транспортное средство: Грузовик";
            }
            else if (Vehicle is MotorCar)
            {
                return $"Время в пути: {Time}, Потрачено топлива: {ConsumedFuel}л, Расстояние поездки: {DistanceInMeters}м, Транспортное средство: Легковой автомобиль";
            }
            else if (Vehicle is Motorcycle)
            {
                return $"Время в пути: {Time}, Потрачено топлива: {ConsumedFuel}л, Расстояние поездки: {DistanceInMeters}м, Транспортное средство: Мотоцикл";
            }

            return $"Время в полёте: {Time}, Потрачено топлива: {ConsumedFuel}л, Расстояние полёта: {DistanceInMeters}м, Транспортное средство: Самолет";

        }
    }
}
