using System;

namespace DesignPatterns.Behavioral.Interpreter
{
    class TerminalExpression : Expression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Terminal expression interpreted");
        }
    }
}
