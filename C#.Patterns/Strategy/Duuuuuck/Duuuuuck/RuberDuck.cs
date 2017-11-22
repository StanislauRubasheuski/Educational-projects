using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Duuuuuck
{
    class RuberDuck: Duck
    {
        public RuberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("Я выгляжу как резиновая утка.");
        }
    }
}
