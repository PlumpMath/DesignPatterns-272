using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Interpreter
{
    // This example is pretty much identical to the wikipedia entry.
    class Interpreter : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Interpreter pattern--\n");

            var expressions = new List<Expression>
            {
                new TerminalExpression(),
                new TerminalExpression(),
                new NonterminalExpression(),
                new NonterminalExpression(),
                new TerminalExpression()
            };

            var context = new Context();
            foreach (var expression in expressions)
            {
                expression.Interpret(context);
            }

            Console.WriteLine();
        }
    }
}
