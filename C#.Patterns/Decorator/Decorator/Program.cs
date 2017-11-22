using System;

namespace Decorator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Beverage beverage1 = new Expresso();
            Console.WriteLine(beverage1.getDescription() + ":\t" + beverage1.Cost());

            Beverage beverage2 = new HouseBlend();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Soy(beverage2);
            Console.WriteLine(beverage2.getDescription() + ":\t" + beverage2.Cost());

            Beverage beverage3 = new Decaf();
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.getDescription() + ":\t" + beverage3.Cost());
        }
    }
}
