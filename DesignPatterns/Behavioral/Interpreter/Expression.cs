namespace DesignPatterns.Behavioral.Interpreter
{
    abstract class Expression
    {
        public abstract void Interpret(Context context);
    }
}
