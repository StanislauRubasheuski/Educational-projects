using System;
namespace Decorator
{
    public class DarkRoar: Beverage
    {
        public DarkRoar()
        {
            description = "Dark Roar Coffee";
        }

        public override double Cost()
        {
            return 1.25;
        }

        public override string getDescription()
        {
            return description;
        }
    }
}
