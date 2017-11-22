using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Duuuuuck
{
    class ModelDuck: Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quacking();
        }

        public override void Display()
        {
            Console.WriteLine("Я выгляжу как утка-приманка.");
        }
    }
}
