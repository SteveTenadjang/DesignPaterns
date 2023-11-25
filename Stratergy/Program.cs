
using Stratergy.Characters;
using Stratergy.Stratergies;

namespace Stratergy
{
    public class Program
    {
        //The stratery design patern defines a family 
        //of algorithms, each encapsulated and inter-changable
       //It can vary independent of the user

        public static void Main(string[] args)
        {
            Character queen = new Queen();
            queen.Fight();
            
            Console.WriteLine("*****************");

            Character king = new King();
            king.Fight();

            Console.WriteLine("*****************");

            king.FightingToolBehaviour = new KnifeBehaviour();
            king.Fight();

            Console.WriteLine("*****************");

            Character troll = new Troll();
            troll.Fight();
        }
    }
}