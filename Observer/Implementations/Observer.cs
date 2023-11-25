using Observer.Interfaces;

namespace Observer.Implementations
{
    internal class Observer : IObserver
    {
        public void Update(IObservable observable)
        {
            int state = ((Observable)observable).State;
            Console.WriteLine("************ Observer **************");
            Console.WriteLine($"Previous State -> State = {state}");
            Console.WriteLine($"New State -> state = {++state}");
            Console.WriteLine("************************************");
        }
    }
}
