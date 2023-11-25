// See https://aka.ms/new-console-template for more information

/*
 * In this patern the objects subcribe to an observable and perform tasks according to thier needs
 * an get notified when ever an event occures
 */
using Observer.Implementations;
using Observer.Interfaces;

Observable observable = new();
IObserver observer = new Observer.Implementations.Observer();
IObserver observer1 = new Observer1();
IObserver observer2 = new Observer.Implementations.Observer();

observable.Subcribe(observer);
observable.Subcribe(observer1);
observable.Subcribe(observer2);
observable.State = 55;
observable.State = 25;
observable.Unsubcribe(observer);
observable.State = 80;
