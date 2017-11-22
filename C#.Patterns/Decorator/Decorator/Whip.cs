using System;
namespace Decorator
{
    public class Whip: CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return 0.1 + beverage.Cost();
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Whip";
        }
    }
}
