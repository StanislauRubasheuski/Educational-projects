using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Duuuuuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck1 = new MallardDuck();
            Duck duck2 = new RuberDuck();
            Duck duck3 = new ModelDuck();
            duck1.PerformFly();
            duck1.PerformQuack();
            duck2.PerformFly();
            duck2.PerformQuack();
            duck3.PerformQuack();
            duck3.PerformFly();
            duck3.SetFlyBehavior(new FlyWithRockets());
            duck3.PerformFly();
            Console.ReadKey();
        }
    }
}
