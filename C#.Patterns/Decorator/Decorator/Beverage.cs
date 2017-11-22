using System;
namespace Decorator
{
    public abstract class Beverage
    {
        protected string description = "Что то неизвестное";

        public abstract double Cost();

        public abstract string getDescription();

    }
}
