using System;

namespace DesignPatterns.Behavioral.Template
{
    class Linux : OperatingSystem
    {
        protected override void LoadOS()
        {
            Console.WriteLine("Loading Linux");
        }

        protected override void ProcessInput()
        {
            Console.WriteLine("Processing input in Linux");
        }

        protected override void LaunchApplication()
        {
            Console.WriteLine("Launching application in Linux");
        }
    }

    class Windows : OperatingSystem
    {
        protected override void LoadOS()
        {
            Console.WriteLine("Loading Windows");
        }

        protected override void ProcessInput()
        {
            Console.WriteLine("Processing input in Windows");
        }

        protected override void LaunchApplication()
        {
            Console.WriteLine("Launching application in Windows");
        }
    }

    class MacOS : OperatingSystem
    {
        protected override void LoadOS()
        {
            Console.WriteLine("Loading MacOS");
        }

        protected override void ProcessInput()
        {
            Console.WriteLine("Processing input in MacOS");
        }

        protected override void LaunchApplication()
        {
            Console.WriteLine("Launching application in MacOS");
        }
    }
}
