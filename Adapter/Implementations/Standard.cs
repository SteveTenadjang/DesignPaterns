using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Interfaces;

namespace Adapter.Implementations
{
    internal class Standard : IStandard
    {
        public void Operation(int nb1, int nb2)
        {
            double result = nb1 * nb2;
            Console.WriteLine("*******************************");
            Console.WriteLine("*** Standard implementation ***");
            Console.WriteLine($"**** Result = {result}");
            Console.WriteLine("*******************************");
        }
    }
}
