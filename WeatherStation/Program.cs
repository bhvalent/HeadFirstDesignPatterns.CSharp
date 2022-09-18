using WeatherStation;

var weatherData = new WeatherData();
var currentConditions = new CurrentConditionsDisplay(weatherData);
var statistics = new StatisticsDisplay(weatherData);
var forecast = new ForecastDisplay(weatherData);
var heatIndex = new HeatIndexDisplay(weatherData);

weatherData.SetMeasurements(80, 65, 30.4);
weatherData.SetMeasurements(82, 70, 29.2);
weatherData.SetMeasurements(78, 90, 29.2);
