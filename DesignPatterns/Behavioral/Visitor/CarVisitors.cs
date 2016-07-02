using System;

namespace DesignPatterns.Behavioral.Visitor
{
    interface ICarElementVisitor
    {
        void Visit(Wheel wheel);
        void Visit(Body body);
        void Visit(Engine engine);
        void Visit(Car car);
    }

    class CarInspectionVisitor : ICarElementVisitor
    {
        public void Visit(Engine engine)
        {
            Console.WriteLine("Inspecting engine");
        }

        public void Visit(Car car)
        {
            Console.WriteLine("Inspecting car");
        }

        public void Visit(Body body)
        {
            Console.WriteLine("Inspecting body");
        }

        public void Visit(Wheel wheel)
        {
            Console.WriteLine("Inspecting wheel " + wheel.Index);
        }
    }

    class CarRepairVisitor : ICarElementVisitor
    {
        public void Visit(Engine engine)
        {
            Console.WriteLine("Repairing engine");
        }

        public void Visit(Car car)
        {
            Console.WriteLine("Repairing car");
        }

        public void Visit(Body body)
        {
            Console.WriteLine("Repairing body");
        }

        public void Visit(Wheel wheel)
        {
            Console.WriteLine("Repairing wheel " + wheel.Index);
        }
    }

    class CarDemolishVisitor : ICarElementVisitor
    {
        public void Visit(Engine engine)
        {
            Console.WriteLine("Demolishing engine");
        }

        public void Visit(Car car)
        {
            Console.WriteLine("Demolishing car");
        }

        public void Visit(Body body)
        {
            Console.WriteLine("Demolishing body");
        }

        public void Visit(Wheel wheel)
        {
            Console.WriteLine("Demolishing wheel " + wheel.Index);
        }
    }
}
