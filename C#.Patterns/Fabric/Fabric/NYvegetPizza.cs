using System;
using System.Collections;
namespace Fabric
{
    public class NYvegetPizza: Pizza
    {
        public NYvegetPizza()
        {
            name = "Нью-йоркская вегетарианская пицца";
            dough = "Тонкая основа";
            sauce = "Вегетарианский соус из листьев бамбука";
            topings.Add("Заячья трава");
        }
    }
}
