using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Interfaces;

namespace Adapter
{
    internal class Client
    {
        public IStandard? Standard { private get; set; }

        public void Process(int nb1, int nb2)
        {
            Standard.Operation(nb1, nb2);
        }

    }
}
