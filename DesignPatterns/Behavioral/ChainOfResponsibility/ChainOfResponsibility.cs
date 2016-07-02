using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    class ChainOfResponsibility : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("--Chain of responsibility pattern--\n");

            var informer = new PublicInformer(new PrivateInformer(new ConfidentialInformer(new SecretInformer())));

            var message1 = new Message { Data = "message1", SecurityLevel = SecurityLevel.Public };
            var message2 = new Message { Data = "message2", SecurityLevel = SecurityLevel.Confidential };
            var message3 = new Message { Data = "message3", SecurityLevel = SecurityLevel.Private };
            var message4 = new Message { Data = "message4", SecurityLevel = SecurityLevel.Secret };
            var message5 = new Message { Data = "message5", SecurityLevel = SecurityLevel.Secret };

            informer.Inform(message1);
            informer.Inform(message2);
            informer.Inform(message3);
            informer.Inform(message4);
            informer.Inform(message5);

            Console.WriteLine();
        }
    }
   
}
