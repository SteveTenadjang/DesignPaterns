/*
 * Category : Behaviour
 * 
 * Objective : Define a family of algorithms, encapsulate each of them
 *  and make them interchangeable while asuring that each of the algoruthms 
 *  can evolve independently of thier usage. 
 *  
 *  Result: Isolate algorithms belonging to a similar family of algorithms 
 */

using Stratergy.Characters;
using Stratergy.Stratergies;

namespace Stratergy
{
    public class Program
    {
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