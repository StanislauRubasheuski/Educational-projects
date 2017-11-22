using System;
namespace Decorator
{
    public class Mocha: CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.15;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Mocha";
        }
    }
}
