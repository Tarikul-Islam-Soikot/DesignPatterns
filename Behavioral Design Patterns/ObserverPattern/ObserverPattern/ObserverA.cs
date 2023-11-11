using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ObserverA: IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("Notification from Observer A\n Message from Subject: " + message);
        }
    }
}
