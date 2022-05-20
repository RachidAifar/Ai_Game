using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Game
{
    class AI_Game1Node : AbstractNode
    {
        public AI_Game1Node(AbstractState startState) : base(startState) { }
        public AI_Game1Node(AbstractNode node) : base(node) { }

        public override List<AbstractNode> Expand()
        {
            List<AbstractNode> newNodes = new List<AbstractNode>();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    AI_Game1Node newNode = new AI_Game1Node(this);
                    if ((newNode.State as AI_Game1).Move(i) != null)
                    {
                        if (!newNodes.Contains(newNode))
                            newNodes.Add(newNode);
                    }
                }
            }

            return newNodes;
        }
    }
}
