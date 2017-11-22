using System;
using System.Collections;

namespace MeteoStation
{
    public class WeatherData: Subject
    {
        ArrayList observers;
        float temp;
        float humidity;
        float pressure;

        public WeatherData()
        {
            observers = new ArrayList();
        }

        public void RegisterObserver(Observer o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(Observer o)
        {
            int index = observers.IndexOf(o);
            if (index >= 0)
                observers.RemoveAt(index);
        }

        public void NotifyObserver()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                Observer observer = (Observer)observers[i];
                observer.Update(temp, humidity, pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObserver();
        }

        public void setMeasure(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}
