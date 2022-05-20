using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Game
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            AI_Game1 tower = new AI_Game1();
            do
            {
                if (tower.SuperOerator(rnd.Next(0, tower.NrOfOperators + 1)) != null)
                {
                    tower.display();
                }
            } while (!tower.IsGoalState());

            Console.ReadLine();
        }
    }
}
