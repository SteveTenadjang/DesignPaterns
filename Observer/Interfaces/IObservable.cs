using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Interfaces
{
    internal interface IObservable
    {
        public void Subcribe(IObserver observer);
        public void Unsubcribe(IObserver observer);
        public void NotifyObservers();
    }
}
