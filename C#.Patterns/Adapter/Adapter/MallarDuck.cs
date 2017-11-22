using System;
namespace Adapter
{
    public class MallarDuck: Duck
    {
        public void Fly()
        {
            Console.WriteLine("Я лечуууу!!!");
        }

        public void Quack()
        {
            Console.WriteLine("Ква-ква-ква!!!");
        }
    }
}
