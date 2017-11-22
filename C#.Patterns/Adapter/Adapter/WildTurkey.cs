using System;
namespace Adapter
{
    public class WildTurkey: Turkey
    {
        public void Gobble()
        {
            Console.WriteLine("Гобл! Гобл!");
        }

        public void Fly()
        {
            Console.WriteLine("Я лечу! Недалеко.");
        }
    }
}
