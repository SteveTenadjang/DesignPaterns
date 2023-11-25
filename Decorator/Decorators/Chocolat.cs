using Decorator.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    internal class Chocolat : Decorator
    {
        public Chocolat(Drink drink) : base(drink) {
            Description = $"{drink.Description} with Chcolate";
        }

        public override double Price()
        {
            return Drink.Price() + 300;
        }
    }
}
