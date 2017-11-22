using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Duuuuuck
{
    abstract class Duck
    {
        protected FlyBehavior flyBehavior;
        protected QuackBehavior quackBehavior;


        public abstract void Display();

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("Все утки плавают");
        }

        public void SetFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void SetQuackBehavior(QuackBehavior qb)
        {
            quackBehavior = qb;
        }
    }
}
