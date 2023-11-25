using Stratergy.Stratergies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratergy.Characters
{
    internal class King : Character
    {
        public King()
        {
            FightingToolBehaviour = new AxeBehaviour();
        }
        public override void Fight()
        {
            Score += 1;
            Console.WriteLine("I am a King ...");
            FightingToolBehaviour?.UseFightingTool();
            Console.WriteLine($"Score: {Score}");
        }
    }
}
