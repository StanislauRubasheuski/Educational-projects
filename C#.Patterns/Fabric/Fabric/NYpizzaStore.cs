using System;
namespace Fabric
{
    public class NYpizzaStore: PizzaStore
    {
        protected override Pizza CreatePizza(string name)
        {
            if (name == "cheese")
                return new NYcheesePizza();
            if (name == "veget")
                return new NYvegetPizza();
            return null;
        }
    }
}
