using System;

namespace DesignPatterns.Behavioral.Interpreter
{
    class NonterminalExpression : Expression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Non-terminal expression interpreted");
        }
    }
}
