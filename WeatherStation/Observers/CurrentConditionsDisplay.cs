namespace WeatherStation
{
    public class CurrentConditionsDisplay : IObserver<WeatherData>, IDisplayWeather
    {
        private readonly IDisposable _unsubscriber;
        private double _temperature;
        private double _humidity;

        public CurrentConditionsDisplay(IObservable<WeatherData> weatherData)
        {
            _unsubscriber = weatherData?.Subscribe(this) ?? throw new ArgumentNullException(nameof(weatherData));
        }

        public void Display()
        {
            Console.WriteLine($"Current Conditions: {_temperature}F degrees and {_humidity}% humidity");
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
                _temperature = value.Temperature;
                _humidity = value.Humidity;
                Display();
            }
        }
    }
}
