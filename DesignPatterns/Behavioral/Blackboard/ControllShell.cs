using System.Threading;
using System.Linq;

namespace DesignPatterns.Behavioral.Blackboard
{
    class ControlShell
    {
        private BlackboardRepository _blackboard;

        public ControlShell(BlackboardRepository blackboard)
        {
            _blackboard = blackboard;
        }

        public bool HasProblem()
        {
            return _blackboard.Items.Any(item => item.ProblemType != ProblemType.Solved);
        }

        // blocking
        public ItemOfInterest GetItem(ProblemType problemType)
        {
            bool lockTaken = false;
            Monitor.Enter(_blackboard, ref lockTaken);

            ItemOfInterest item = null;
            try
            {
                item = _blackboard.Items.FirstOrDefault(it => it.ProblemType == problemType && it.State != ItemState.Processing);
                if (item != null)
                    item.State = ItemState.Processing;
            }
            finally
            {
                if (lockTaken)
                    Monitor.Exit(_blackboard);
            }

            return item;
        }
    }
}
