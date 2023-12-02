using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Implementations
{
    internal class NewStandard
    {
        public double Calculate(double nb1, double nb2) => 2 * nb1 + nb2;

        public void Print(double nb)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("--- Adapt implementation ---");
            Console.WriteLine($"--- Result = {nb}");
            Console.WriteLine("----------------------------");
        }
    }
}
