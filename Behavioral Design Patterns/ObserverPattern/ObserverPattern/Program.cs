using ObserverPattern;

IObserver observerA = new ObserverA();
IObserver observerB = new ObserverB();

Subject subject = new Subject();

subject.Attach(observerA);
subject.Attach(observerB);

subject.NotifyObservers("Attached observers A & B\n");

subject.Detach(observerA);

subject.NotifyObservers("Dettached observer A\n");

