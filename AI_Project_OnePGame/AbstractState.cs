using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Project_OnePGame
{
    public abstract class AbstractState
    {
        public abstract bool IsState();
        public abstract bool IsGoalState();

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
