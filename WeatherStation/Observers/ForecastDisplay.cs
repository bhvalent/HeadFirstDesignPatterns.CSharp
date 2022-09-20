namespace WeatherStation
{
    public class ForecastDisplay : IObserver<WeatherData>, IDisplayWeather
    {
        private readonly IDisposable _unsubscriber;
        private double _currentPressure = 29.92;
        private double _lastPressure;

        public ForecastDisplay(IObservable<WeatherData> weatherData)
        {
            _unsubscriber = weatherData?.Subscribe(this) ?? throw new ArgumentNullException(nameof(weatherData));
        }

        public void Display()
        {
            if (_currentPressure > _lastPressure)
            {
                Console.WriteLine("Forecast: Improving weather on the way!");
            }
            else if (_currentPressure == _lastPressure)
            {
                Console.WriteLine("Forecast: More of the same");
            }
            else if (_currentPressure < _lastPressure)
            {
                Console.WriteLine("Forecast: Watch out for cooler, rainy weather");
            }
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
                _lastPressure = _currentPressure;
                _currentPressure = value.Pressure;
                Display();
            }
        }
    }
}
