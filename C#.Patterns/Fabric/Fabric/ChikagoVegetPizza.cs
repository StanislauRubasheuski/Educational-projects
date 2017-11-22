using System;
using System.Collections;
namespace Fabric
{
    public class ChikagoVegetPizza: Pizza
    {
        public ChikagoVegetPizza()
        {
            name = "Чикагская вегетарианская пицца";
            dough = "Толстая основа";
            sauce = "Водорослевый";
            topings.Add("Креветки");
        }

        public override void Cut()
        {
            Console.WriteLine("Режем пиццу прямоугольниками");
        }
    }
}
