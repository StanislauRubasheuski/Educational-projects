using System;
namespace Adapter
{
    public class DuckAdapter: Turkey
    {
        Duck duck;

        public DuckAdapter(Duck duck)
        {
            this.duck = duck;
        }

        public void Gobble()
        {
            duck.Quack();
        }

        public void Fly()
        {
            Console.Write("В пять раз меньше...");
            duck.Fly();
        }
    }
}
