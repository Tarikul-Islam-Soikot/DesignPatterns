﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeDecoratorPattern.Interface;

namespace CoffeeDecoratorPattern.Implementation
{
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Sugar Added";
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() + 1;
        }
    }
}
