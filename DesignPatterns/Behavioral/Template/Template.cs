using System;

namespace DesignPatterns.Behavioral.Template
{
    class Template : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Template pattern--\n");

            var linux = new Linux();
            linux.Run();

            var windows = new Windows();
            windows.Run();

            var macOS = new MacOS();
            macOS.Run();

            Console.WriteLine();
        }
    }
}
