using Adapter.Implementations;
using Adapter.Interfaces;

namespace Adapter.Adapters
{
    internal class AdaptWithInheritance : NewStandard, IStandard
    {
        public void Operation(int nb1, int nb2)
        {
            double result = base.Calculate(nb1, nb2);
            base.Print(result);
        }
    }
}
