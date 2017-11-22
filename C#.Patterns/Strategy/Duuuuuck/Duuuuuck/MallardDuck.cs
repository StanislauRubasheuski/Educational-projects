using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Duuuuuck
{
    class MallardDuck: Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quacking();
        }

        public override void Display()
        {
            Console.WriteLine("Я выгляжу как настоящая утка.");
        }
    }
}
