using System;

namespace DesignPatterns.Behavioral.Blackboard
{
    interface KnowledgeSource
    {
        void Process(ItemOfInterest item);
    }

    class Scientist : KnowledgeSource
    {
        public void Process(ItemOfInterest item)
        {
            if (item.ProblemType == ProblemType.Scientific)
                item.ProblemType = ProblemType.Economical;

            item.State = ItemState.Processed;

            Console.WriteLine("Scientist processed item " + item.Name);
        }
    }

    class Economist : KnowledgeSource
    {
        public void Process(ItemOfInterest item)
        {
            if (item.ProblemType == ProblemType.Economical)
                item.ProblemType = ProblemType.Philosophical;

            item.State = ItemState.Processed;

            Console.WriteLine("Economist processed item " + item.Name);
        }
    }

    class Philosopher : KnowledgeSource
    {
        public void Process(ItemOfInterest item)
        {
            if (item.ProblemType == ProblemType.Philosophical)
                item.ProblemType = ProblemType.Solved;

            item.State = ItemState.Processed;

            Console.WriteLine("Philosopher processed item " + item.Name);
        }
    }
}
