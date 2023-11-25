using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratergy.Stratergies
{
    internal class ArrowBehaviour : IFightingToolBehaviour
    {
        public void UseFightingTool()
        {
            Console.WriteLine("Am fighting using an Arrow");
        }
    }
}
