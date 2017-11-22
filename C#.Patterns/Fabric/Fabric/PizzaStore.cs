using System;
namespace Fabric
{
    public abstract class PizzaStore
    {
        protected abstract Pizza CreatePizza(string name);

        public void OrderPizza(string name)
        {
            Pizza pizza;
            pizza = CreatePizza(name);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }
    }
}
