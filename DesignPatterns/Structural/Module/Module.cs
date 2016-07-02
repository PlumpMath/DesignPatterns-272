using System;

namespace DesignPatterns.Structural.Module
{
    // Group behavior together into a subclass.
    class Module : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Module pattern--\n");

            var symphony9 = Symphony9.Instance;

            symphony9.Prepare();

            symphony9.PlayFirstMovement();
            symphony9.PlaySecondMovement();
            symphony9.PlayThirdMovement();
            symphony9.PlayFourthMovement();

            symphony9.Unprepare();

            Console.WriteLine();
        }
    }
}
