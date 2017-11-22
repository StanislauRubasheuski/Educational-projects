using System;
namespace Decorator
{
    public class Decaf: Beverage
    {
        public Decaf()
        {
            description = "Decaf";
        }

        public override double Cost()
        {
            return 2;
        }

        public override string getDescription()
        {
            return description;
        }
    }
}
