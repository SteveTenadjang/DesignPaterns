using Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Implementations
{
    internal class Standard : IStandard
    {
        public void Process()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("*** Standard implementation ***");
            Console.WriteLine("*******************************");
        }
    }
}
