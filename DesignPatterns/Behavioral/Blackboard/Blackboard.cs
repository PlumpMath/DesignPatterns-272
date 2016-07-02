using System;
using System.Threading;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Blackboard
{
    class Blackboard : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Blackboard pattern--\n");

            const int problemCount = 25;

            var itemsOfInterest = new List<ItemOfInterest>();
            for (int i = 0; i < problemCount; i++)
            {
                itemsOfInterest.Add(new ItemOfInterest { Name = (i+1).ToString() });
            }

            var problems = new BlackboardRepository(itemsOfInterest);
            var controller = new Controller(problems);

            var scientist = new Thread(controller.ScientistWork);
            var economist = new Thread(controller.EconomistWork);
            var philosopher = new Thread(controller.PhilosopherWork);

            scientist.Start();
            economist.Start();
            philosopher.Start();

            scientist.Join();
            economist.Join();
            philosopher.Join();
           
            Console.WriteLine();
        }

        private class Controller
        {
            private readonly ControlShell _controllShell;

            public Controller(BlackboardRepository repository)
            {
                _controllShell = new ControlShell(repository);
            }

            public void ScientistWork()
        	{
                var scientist = new Scientist();

                while (_controllShell.HasProblem())
                {
                    var item = _controllShell.GetItem(ProblemType.Scientific);
                    if (item != null)
                        scientist.Process(item);
                }
        	}

            public void EconomistWork()
        	{
                var economist = new Economist();

                while (_controllShell.HasProblem())
                {
                    var item = _controllShell.GetItem(ProblemType.Economical);
                    if (item != null)
                        economist.Process(item);
                }
        	}

            public void PhilosopherWork()
        	{
                var philosopher= new Philosopher();

                while (_controllShell.HasProblem())
                {
                    var item = _controllShell.GetItem(ProblemType.Philosophical);
                    if (item != null)
                        philosopher.Process(item);
                }
        	}
        }

    }
}
