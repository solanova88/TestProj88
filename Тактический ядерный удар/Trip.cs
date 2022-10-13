namespace Тактический_ядерный_удар
{
    public class Trip
    {
        public TimeSpan Time;
        public double ConsumedFuel;
        public double DistanceInMeters;

        public Trip(TimeSpan time, double consumedFuel, double distanceInMeters)
        {
            Time = time;
            ConsumedFuel = consumedFuel;
            DistanceInMeters = distanceInMeters;
        }

        public override string ToString()
        {

            return $"Время в пути: {Time}, Потрачено топлива: {ConsumedFuel}л, Расстояние поездки: {DistanceInMeters}м";
        }
    }
}
