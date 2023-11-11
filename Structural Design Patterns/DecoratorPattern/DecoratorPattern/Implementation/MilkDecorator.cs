using CoffeeDecoratorPattern.Interface;

namespace CoffeeDecoratorPattern.Implementation
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Milk Added";
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() + 1.2m;
        }
    }
}
