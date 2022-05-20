using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Game
{
    class AI_Game1 : AbstractState
    {
            private static int[] GoalTower = new int[8];
            private Stack<int> Tower = new Stack<int>();
            private List<int> numsInStack = new List<int>();

            public AI_Game1()
            {
                Tower.Push(1);
                Tower.Push(4);
                Tower.Push(5);
                Tower.Push(8);
                Tower.Push(2);
                Tower.Push(3);
                Tower.Push(7);
                Tower.Push(6);
                for (int i = 0; i < Tower.Count; i++)
                {
                    Console.WriteLine(Tower.ElementAt(i));
                }
                Console.WriteLine("------------------------");
            }
            public void display()
            {
                for (int i = 0; i < GoalTower.Length; i++)
                {
                    Console.WriteLine(GoalTower[i]);
                }
                Console.WriteLine("------------------------");
            }
            public override bool IsGoalState()
            {
                if (GoalTower.Length ==8)
            {
                    
                    Array.Sort(GoalTower);
                    for (int i = 0; i < 8; i++)
                    {
                        if (GoalTower[i] != i + 1)
                        {
                            return false;
                        }
                    }
                    return true;
                }
                return false;
            }
            private void Sort()
            {
                numsInStack.Sort();
            }
            public AI_Game1 Move(int numOfDiscs)
            {
                for (int i = 0; i < numOfDiscs; i++)
                {
                    numsInStack.Add(Tower.Pop());

                }
                Sort();
                for (int i = 0; i < numOfDiscs; i++)
                {
                    GoalTower[i] = numsInStack[i];
                }
                //Clear the list
                numsInStack.Clear();
                return this;
            }
            public AI_Game1 SuperOerator(int i)
            {
                switch (i)
                {
                    case 1: return Move(1);
                    case 2: return Move(2);
                    case 3: return Move(3);
                    case 4: return Move(4);
                    case 5: return Move(5);
                    case 6: return Move(6);
                    case 7: return Move(7);
                    case 8: return Move(8);
                    default: return null;
                }
            }
            public int NrOfOperators
            {
                get { return Tower.Count; }
            }
            public override bool IsState()
            {
                throw new NotImplementedException();
            }
    }
}
   