using System;
namespace Decorator
{
    public class HouseBlend: Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }

        public override double Cost()
        {
            return 0.89;
        }

        public override string getDescription()
        {
            return description;
        }
    }
}
