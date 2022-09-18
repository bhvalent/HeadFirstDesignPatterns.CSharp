namespace WeatherStation
{
    public class StatisticsDisplay : IObserver<WeatherData>, IDisplayWeather
    {
        private readonly IDisposable _unsubscriber;
        private double _minTemperature = double.MaxValue;
        private double _maxTemperature;
        private int _numOfReadings;
        private double _tempSum;


        public StatisticsDisplay(IObservable<WeatherData> weatherData)
        {
            _unsubscriber = weatherData.Subscribe(this) ?? throw new ArgumentNullException(nameof(weatherData));
        }

        public void Display()
        {
            Console.WriteLine($"Avg/Max/Min temperature = {_tempSum / _numOfReadings}/{_maxTemperature}/{_minTemperature}");
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
                var temperature = value.Temperature;
                if (temperature < _minTemperature) _minTemperature = temperature;
                if (temperature > _maxTemperature) _maxTemperature = temperature;
                _numOfReadings++;
                _tempSum += temperature;
                Display();
            }
        }
    }
}
