using System;
namespace MeteoStation
{
    public class Statistics: Observer, DisplayElement
    {
        float temp;
        float humidity;
        float pressure;
        Subject weatherData;

        public Statistics(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Здесь показана статистика погоды");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }
    }
}
