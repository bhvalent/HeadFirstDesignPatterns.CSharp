namespace WeatherStation
{
    public class WeatherData : IObservable<WeatherData>
    {
        private List<IObserver<WeatherData>> _observers;

        public double Temperature { get; private set; }
        public double Humidity { get; private set; }
        public double Pressure { get; private set; }

        public WeatherData()
        {
            _observers = new List<IObserver<WeatherData>>();
        }

        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            if (!_observers.Contains(observer)) _observers.Add(observer);
            return new Unsubscriber<WeatherData>(_observers, observer);
        }

        public void MeasurementsChanged()
        {
            foreach (var observer in _observers)
            {
                observer.OnNext(this);
            }
        }

        public void SetMeasurements(double temperature, double humidity, double pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            MeasurementsChanged();
        }
    }
}
