using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Implementations
{
    internal class Observer1 : IObserver
    {
        public void Update(IObservable observable)
        {
            int state = ((Observable)observable).State;
            Console.WriteLine("************ Observer 1 **************");
            Console.WriteLine($"Previous State -> State = {state}");
            Console.WriteLine($"New State is {(state % 2 == 0 ? "Pair" : "Unpair") }");
            Console.WriteLine("************************************");
        }
    }
}
