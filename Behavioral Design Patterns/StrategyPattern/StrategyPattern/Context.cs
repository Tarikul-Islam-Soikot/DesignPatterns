using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Context
    {
        private IStrategy _strategy;

        public Context()
        {
                
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public string ConcatStringList(List<string> letterList)
        {
            var resultList = _strategy.DoAlgorithm(letterList);

            return string.Join(",", resultList);
        }
    }
}
