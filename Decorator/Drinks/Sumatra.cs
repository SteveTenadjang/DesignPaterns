using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Drinks
{
    internal class Sumatra : Drink
    {
        public Sumatra()
        {
            Description = "Sumatra";
        }

        public override double Price()
        {
            return 1500;
        }
    }
}
