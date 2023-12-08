/*
 * Category: Behaviour
 * 
 * Objective: This patterns define a single to many relationship, 
 *  the relation is established in sort a way that when the state of an object changes,
 *  all its dependants are notified and updated automatically.
 *  
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
