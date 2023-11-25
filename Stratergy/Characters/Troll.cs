using Stratergy.Stratergies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratergy.Characters
{
    internal class Troll : Character
    {
        public Troll()
        {
            FightingToolBehaviour = new KnifeBehaviour();
        }
        public override void Fight()
        {
            Score += 2;
            Console.WriteLine("I am a Troll ...");
            FightingToolBehaviour?.UseFightingTool();
            Console.WriteLine($"Score: {Score}");
        }
    }
}
