using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Implementations;
using Adapter.Interfaces;

namespace Adapter.Adapters
{
    internal class Adapt : IStandard
    {
        private NewStandard NewStandard = new();

        public void Operation(int nb1, int nb2)
        {
            double result = NewStandard.Calculate(nb1, nb2);
            NewStandard.Print(result);
        }
    }
}
