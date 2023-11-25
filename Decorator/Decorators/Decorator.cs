using Decorator.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    internal abstract class Decorator : Drink
    {
        protected Drink Drink { get; set; }

        public Decorator(Drink drink)
        {
            Drink = drink;
        }
    }
}
