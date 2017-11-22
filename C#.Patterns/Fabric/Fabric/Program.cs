using System;

namespace Fabric
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s1 = "cheese";
            string s2 = "veget";
            NYpizzaStore nyStore = new NYpizzaStore();
            ChikagoPizzaStore ChiStore = new ChikagoPizzaStore();
            nyStore.OrderPizza(s1);
            ChiStore.OrderPizza(s1);
            nyStore.OrderPizza(s2);
            ChiStore.OrderPizza(s2);
        }
    }
}
