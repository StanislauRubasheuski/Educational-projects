using System;
using System.Collections;
namespace Fabric
{
    public class ChikagoCheesePizza: Pizza
    {
        public ChikagoCheesePizza()
        {
            name = "Чикагская пицца с сыром";
            dough = "Толстая основа";
            sauce = "Чили";
            topings.Add("Оливки рыба колбаска");
        }

        public override void Cut()
        {
            Console.WriteLine("Режем пиццу прямоугольниками");
        }
    }
}
