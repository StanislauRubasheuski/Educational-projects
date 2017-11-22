using System;
namespace Fabric
{
    public class ChikagoPizzaStore: PizzaStore
    {
        protected override Pizza CreatePizza(string name)
        {
            if (name == "cheese")
                return new ChikagoCheesePizza();
            if (name == "veget")
                return new ChikagoVegetPizza();
            return null;
        }
    }
}
