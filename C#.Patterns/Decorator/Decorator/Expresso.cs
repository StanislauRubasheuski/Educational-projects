using System;
namespace Decorator
{
    public class Expresso: Beverage
    {
        public Expresso()
        {
            description = "Expresso";
        }

        public override double Cost()
        {
            return 1.99d;
        }

        public override string getDescription()
        {
            return description;
        }
    }
}
