using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Drinks
{
    internal class Espresso : Drink
    {
        public Espresso()
        {
            Description = "Espresso";
        }
        public override double Price()
        {
            return 2000;
        }
    }
}
