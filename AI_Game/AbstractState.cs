namespace AI_Game
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