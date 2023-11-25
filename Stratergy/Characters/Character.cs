using Stratergy.Stratergies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratergy.Characters
{
    internal abstract class Character
    {
        protected string Name { get; set; } = string.Empty;
        protected double Score {  get; set; }
        public IFightingToolBehaviour? FightingToolBehaviour { get; set; }
        public abstract void Fight();
    }
}
