using Stratergy.Stratergies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratergy.Characters
{
    internal class Queen : Character
    {
        public Queen()
        {
            FightingToolBehaviour = new ArrowBehaviour();
        }
        public override void Fight()
        {
            Score += 4;
            Console.WriteLine("I am a Queen ...");
            FightingToolBehaviour?.UseFightingTool();
            Console.WriteLine($"Score: {Score}");

            if(Score > 15)
                FightingToolBehaviour = new AxeBehaviour();
        }
    }
}
