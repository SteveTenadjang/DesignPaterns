using Decorator.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    internal class Toffee : Decorator
    {
        public Toffee(Drink drink) : base(drink) {
            Description = $"{drink.Description} with Chcolate";
        }

        public override double Price()
        {
            return Drink.Price() + 450;
        }
    }
}
