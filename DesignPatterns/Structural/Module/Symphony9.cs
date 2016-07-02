using System;

namespace DesignPatterns.Structural.Module
{
    class Symphony9
    {
        private static Symphony9 _instance;
        public static Symphony9 Instance
        {
            get
            {
                return _instance ?? (_instance = new Symphony9());
            }
        }
        private Symphony9()
        {

        }

        public void Prepare()
        {
            Console.WriteLine("Orchestra entered.");
            Console.WriteLine("Instruments tuned.");
        }

        public void Unprepare()
        {
            Console.WriteLine("Orchestra bow.");
            Console.WriteLine("Orchestra leave.");
        }

        public void PlayFirstMovement()
        {
            Console.WriteLine("Allegro ma non troppo, un poco maestoso.");
        }

        public void PlaySecondMovement()
        {
            Console.WriteLine("Scherzo: molto vivace");
        }

        public void PlayThirdMovement()
        {
            Console.WriteLine("Adagio molto e cantibile");
        }

        public void PlayFourthMovement()
        {
            Console.WriteLine("Recitative");
        }
    }
}
