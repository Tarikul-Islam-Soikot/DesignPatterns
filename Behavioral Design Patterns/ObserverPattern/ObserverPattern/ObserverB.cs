using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ObserverB: IObserver
    {
        public ObserverB() { }  

        public void Update(string message)
        {
            Console.WriteLine("Notification from Observer B\n Message from Subject: " + message);
        }
    }
}
