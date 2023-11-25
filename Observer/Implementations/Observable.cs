using Observer.Interfaces;

namespace Observer.Implementations
{
    internal class Observable : IObservable
    {
        public int State { get => state; set { state = value; NotifyObservers(); } }
        protected List<IObserver> Observers = new();
        private int state = 10;

        public void NotifyObservers()
        {
            foreach (var observer in Observers)
                observer.Update(this);
        }

        public void Subcribe(IObserver observer)
            => Observers.Add(observer);

        public void Unsubcribe(IObserver observer)
            => Observers.Remove(observer);
    }
}
