using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Duuuuuck
{
    class FlyNoWay: FlyBehavior
    {
        public  void Fly()
        {
            Console.WriteLine("Я не умею летать!");
        }
    }
}
