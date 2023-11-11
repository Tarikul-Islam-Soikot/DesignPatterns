using AdapterPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Children
    {
        private IHealthyFood _adpater;
        public Children(IHealthyFood adpater)
        {
            _adpater = adpater;
        }
        public void HaveFood()
        {
            _adpater.Eat();
        }
    }
}
