using Proxy.Interfaces;

namespace Proxy
{
    internal class Client
    {
        public IStandard? Standard { private get; set; }

        public void Process() => Standard?.Process();
    }
}
