using AdapterPattern.Implementation;
using AdapterPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class FoodAdapter: IHealthyFood
    {
        private JunkFood _junkFood;
        public FoodAdapter(JunkFood junkFood) 
        {
            _junkFood = junkFood;
        }

        public void Eat()
        {
            Console.WriteLine("Eat healthy, stay healthy!");

            _junkFood.EnjoyJunkFood();

        }
    }
}
