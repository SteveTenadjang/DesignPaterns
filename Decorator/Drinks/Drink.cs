using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Drinks
{
    internal abstract class Drink
    {
        public string Description { get; set; } = string.Empty;
        public abstract double Price();
    }
}
