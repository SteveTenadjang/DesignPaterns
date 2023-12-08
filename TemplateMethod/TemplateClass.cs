using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal abstract class TemplateClass
    {
        public double TemplateMethod()
        {
            int Size = Operation1();
            double Sum = 0;
            for (int i = 0; i < Size; i++)
                Sum += Operation2(i);
            
            return Sum;
        }

        protected abstract int Operation1();
        protected abstract double Operation2(int nb);
    }
}
