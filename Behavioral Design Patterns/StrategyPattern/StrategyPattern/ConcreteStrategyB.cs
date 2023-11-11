using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class ConcreteStrategyB : IStrategy
    {
        public List<string> DoAlgorithm(List<string> letterList)
        {
            letterList.Sort();
            letterList.Reverse();

            return letterList;
        }
    }
}
