using System;

namespace DesignPatterns.Behavioral.Visitor
{
    class Visitor : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Visitor pattern--\n");

            var car = new Car();
            car.Accept(new CarInspectionVisitor());
            car.Accept(new CarRepairVisitor());
            car.Accept(new CarDemolishVisitor());

            Console.WriteLine();
        }
    }
}
