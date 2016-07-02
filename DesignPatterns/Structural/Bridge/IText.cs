namespace DesignPatterns.Structural.Bridge
{
    // Abstraction
    //
    // Alternatively, this could be an abstract class which 
    // stores the implementor and is passed in from the derived class
    interface IText
    {
        void Output();
    }
}
