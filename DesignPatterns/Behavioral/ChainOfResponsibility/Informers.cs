using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    abstract class Informer
    {
        private SecurityLevel _securityLevel;
        private Informer _nextInformer;
        private string _name;

        protected Informer(SecurityLevel level, string name, Informer nextInformer = null)
        {
            _securityLevel = level;
            _nextInformer = nextInformer;
            _name = name;
        }

        public void Inform(Message message)
        {
            if (message.SecurityLevel > _securityLevel && _nextInformer != null)
                _nextInformer.Inform(message);
            else
                Console.WriteLine(_name + ": " + message.Data);
        }
    }

    class PublicInformer : Informer
    {
        public PublicInformer(Informer nextInformer = null)
            : base(SecurityLevel.Public, "Public informant", nextInformer)
        {
        }
    }

    class PrivateInformer : Informer
    {
        public PrivateInformer(Informer nextInformer = null)
            : base(SecurityLevel.Private, "Private informant", nextInformer)
        {
        }
    }

    class ConfidentialInformer : Informer
    {
        public ConfidentialInformer(Informer nextInformer = null)
            : base(SecurityLevel.Confidential, "Confidential informant", nextInformer)
        {
        }
    }

    class SecretInformer : Informer
    {
        public SecretInformer(Informer nextInformer = null)
            : base(SecurityLevel.Secret, "Secret informant", nextInformer)
        {
        }
    }
}
