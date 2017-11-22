using System;

namespace MeteoStation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            WeatherData weatherDate = new WeatherData();
            CurrentCondition current = new CurrentCondition(weatherDate);
            Statistics stat = new Statistics(weatherDate);
            Forecast forecast = new Forecast(weatherDate);

            weatherDate.setMeasure(80, 30, 27.5f);
            weatherDate.setMeasure(90, 40, 31.4f);
            weatherDate.setMeasure(20, 10, 15.3f);
        }
    }
}
