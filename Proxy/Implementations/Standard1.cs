using Proxy.Interfaces;

namespace Proxy.Implementations
{
    internal class Standard1 : IStandard
    {
        public void Process()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("*** Standard 1 implementation ***");
            Console.WriteLine("*********************************");
        }
    }
}
