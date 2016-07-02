using System;

namespace DesignPatterns.Structural.Twin
{
    // Multiple inheritence for those languages that do not support it.
    // 
    // Example is derived from:
    //  Twin – A Design Pattern for Modeling Multiple Inheritance 
    class Twin : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Twin pattern--\n");

            var flyingYacht = new FlyingYachtInAir();
            var flyingYacht2 = new FlyingYachtInWater();
            flyingYacht.Sibling = flyingYacht2;
            flyingYacht2.Sibling = flyingYacht;

            flyingYacht.Drive();
            flyingYacht.Fly();

            Console.WriteLine();
        }
    }

    class Boat
    {
        public void Drive()
        {
            Console.WriteLine("Driving");
        }
    }

    class Aeroplane
    {
        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }

    class FlyingYachtInWater : Boat
    {
        public FlyingYachtInAir Sibling { get; set; }

        public void Fly()
        {
            Sibling.Fly();
        }
    }

    class FlyingYachtInAir : Aeroplane
    {
        public FlyingYachtInWater Sibling { get; set; }

        public void Drive()
        {
            Sibling.Drive();
        }
    }
}
