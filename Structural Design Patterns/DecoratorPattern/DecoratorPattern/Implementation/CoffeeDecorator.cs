using CoffeeDecoratorPattern.Interface;

namespace CoffeeDecoratorPattern.Implementation
{
    public abstract class CoffeeDecorator : ICoffee
    {
        protected ICoffee _coffee;
        public CoffeeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public virtual string GetDescription()
        {
            return _coffee.GetDescription();
        }

        public virtual decimal GetPrice()
        {
            return _coffee.GetPrice();
        }
    }
}
