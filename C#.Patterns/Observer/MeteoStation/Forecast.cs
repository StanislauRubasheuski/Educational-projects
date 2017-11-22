using System;
namespace MeteoStation
{
    public class Forecast: Observer, DisplayElement
    {
        float pressure;
        Subject weatherData;

        public Forecast(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Здесь показан прогноз погоды");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.pressure = pressure;
            Display();
        }
    }
}
