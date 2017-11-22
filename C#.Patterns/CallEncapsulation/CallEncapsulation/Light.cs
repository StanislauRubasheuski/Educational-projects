using System;
namespace CallEncapsulation
{
    public class Light
    {
        string s = "";
        public Light(string key)
        {
            s = key;
        }

        public void On()
        {
            Console.WriteLine("Лампочка горит на " + s);
        }

        public void Off()
        {
            Console.WriteLine("Лампочка не горит на " + s);
        }
    }
}
