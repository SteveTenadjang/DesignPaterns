namespace Observer.Interfaces
{
    internal interface IObserver
    {
        public void Update(IObservable observable);
    }
}
