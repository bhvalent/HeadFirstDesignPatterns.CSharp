namespace WeatherStation
{
    public class HeatIndexDisplay : IObserver<WeatherData>, IDisplayWeather
    {
        private readonly IDisposable _unsubscriber;
        private double _heatIndex;

        public HeatIndexDisplay(IObservable<WeatherData> weatherData)
        {
            _unsubscriber = weatherData?.Subscribe(this) ?? throw new ArgumentNullException(nameof(weatherData));
        }

        public void Display()
        {
            Console.WriteLine($"Heat index is {_heatIndex}");
        }

        public void OnCompleted()
        {
            if (_unsubscriber != null) _unsubscriber.Dispose();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"An error occured: {error}");
        }

        public void OnNext(WeatherData value)
        {
            if (value != null)
            {
                _heatIndex = ComputeHeatIndex(value.Temperature, value.Humidity);
                Display();
            }
        }

        private double ComputeHeatIndex(double temperature, double humidity)
        {
            double index = (16.923 + (0.185212 * temperature) + (5.37941 * humidity) - (0.100254 * temperature * humidity)
                            + (0.00941695 * (temperature * temperature)) + (0.00728898 * (humidity * humidity))
                            + (0.000345372 * (temperature * temperature * humidity)) - (0.000814971 * (temperature * humidity * humidity)) +
                            (0.0000102102 * (temperature * temperature * humidity * humidity)) - (0.000038646 * (temperature * temperature * temperature)) + (0.0000291583 *
                            (humidity * humidity * humidity)) + (0.00000142721 * (temperature * temperature * temperature * humidity)) +
                            (0.000000197483 * (temperature * humidity * humidity * humidity)) - (0.0000000218429 * (temperature * temperature * temperature * humidity * humidity)) +
                            0.000000000843296 * (temperature * temperature * humidity * humidity * humidity)) -
                           (0.0000000000481975 * (temperature * temperature * temperature * humidity * humidity * humidity));
            return index;
        }
    }
}
