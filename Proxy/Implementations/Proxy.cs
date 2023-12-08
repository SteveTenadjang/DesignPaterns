using Proxy.Interfaces;

namespace Proxy.Implementations
{
    internal class Proxy : IStandard
    {
        private Standard? Standard;

        public void Process()
        {
            Console.WriteLine("Auth Verification...");
            Console.Write($"Password : ");
            string pasword = Console.ReadLine() ?? string.Empty;

            if (pasword.Equals("1234"))
            {
                Standard = new();
                Standard.Process();
            }
            else 
                throw new Exception("403 : not Authenticated");
        }
    }
}
