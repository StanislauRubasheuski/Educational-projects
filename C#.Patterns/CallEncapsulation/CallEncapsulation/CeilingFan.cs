using System;
namespace CallEncapsulation
{
    public class CeilingFan
    {
        public const int HIGH = 3;
        public const int MEDIUM = 2;
        public const int LOW = 1;
        public const int OFF = 0;
        string location;
        int speed;

        public CeilingFan(string location)
        {
            this.location = location;
            speed = OFF;
        }

        public void High()
        {
            speed = HIGH;
        }

        public void Medium()
        {
            speed = MEDIUM;
        }

        public void Low()
        {
            speed = LOW;
        }

        public int GetSpeed()
        {
            return speed;
        }

        public void Off()
        {
            speed = OFF;
        }
    }
}
