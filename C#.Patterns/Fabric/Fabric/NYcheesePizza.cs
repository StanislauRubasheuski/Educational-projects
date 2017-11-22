using System;
using System.Collections;
namespace Fabric
{
    public class NYcheesePizza: Pizza
    {
        public NYcheesePizza()
        {
            name = "Нью-йоркская пицца с сыром";
            dough = "Тонкое тесто";
            sauce = "Маринара";
            topings.Add("Сыр Реджано");
        }

    }
}
