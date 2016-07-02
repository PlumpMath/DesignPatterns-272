using System;

namespace DesignPatterns.Behavioral.Template
{
    abstract class OperatingSystem
    {
        private void Boot()
        {
            Console.WriteLine("Booting");
        }

        protected abstract void LoadOS();
        protected abstract void ProcessInput();
        protected abstract void LaunchApplication();

        private void Shutdown()
        {
            Console.WriteLine("Shutdown");
        }

        public void Run()
        {
            Boot();
            LoadOS();
            ProcessInput();
            LaunchApplication();
            ProcessInput();
            LaunchApplication();
            Shutdown();
        }
    }

}
