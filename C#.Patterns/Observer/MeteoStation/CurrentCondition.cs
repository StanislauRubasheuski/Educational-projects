using System;
namespace MeteoStation
{
    public class CurrentCondition: Observer, DisplayElement
    {
        float temp;
        float humidity;
        Subject weatherData;

        public CurrentCondition(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Температура: {0}, Влажность: {1}", temp, humidity);
        }
    }
}
