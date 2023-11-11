using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Subject
    {
        private List<IObserver> observers = new List<IObserver>();
        public Subject()
        {
                
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(string message)
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(message);
            }
        }
    }
}
