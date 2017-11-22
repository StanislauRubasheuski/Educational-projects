using System;
namespace Decorator
{
    public class Soy: CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return 0.21 + beverage.Cost();
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Soy";
        }
    }
}
