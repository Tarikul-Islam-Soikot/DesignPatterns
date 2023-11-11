using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeDecoratorPattern.Interface;

namespace CoffeeDecoratorPattern.Implementation
{
    public class SimpleCoffee : ICoffee
    {
        public SimpleCoffee()
        {

        }

        public string GetDescription()
        {
            return "Simple Coffee";
        }

        public decimal GetPrice()
        {
            return 10;
        }
    }
}
