﻿using System;
namespace MeteoStation
{
    public interface Observer
    {
        void Update(float temp, float humidity, float pressure);
    }
}
