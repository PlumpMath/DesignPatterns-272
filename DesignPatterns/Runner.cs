using System;

using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.Factory;
using DesignPatterns.Creational.LazyInitialization;
using DesignPatterns.Creational.Multiton;
using DesignPatterns.Creational.ObjectPool;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.RAII;
using DesignPatterns.Creational.Singleton;

using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.Flyweight;
using DesignPatterns.Structural.MarkerInterface;
using DesignPatterns.Structural.Module;
using DesignPatterns.Structural.Proxy;
using DesignPatterns.Structural.Twin;

using DesignPatterns.Behavioral.Blackboard;
using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Interpreter;
using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.Mediator;
using DesignPatterns.Behavioral.Memento;
using DesignPatterns.Behavioral.NullObject;
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.Servant;
using DesignPatterns.Behavioral.Specification;
using DesignPatterns.Behavioral.State;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.Template;
using DesignPatterns.Behavioral.Visitor;

namespace DesignPatterns
{
    class Runner
    {
        static void Main(string[] args)
        {
            RunCreationalPatterns();
            RunStructuralPatterns();
            RunBehavioralPatterns();

            Console.ReadLine();
        }

        private static void RunCreationalPatterns()
        {
            new AbstractFactory().Run();
            new Builder().Run();
            new Factory().Run();
            new LazyInitialization().Run();
            new Multiton().Run();
            new ObjectPool().Run();
            new Prototype().Run();
            new RAII().Run();
            new Singleton().Run();
        }

        private static void RunStructuralPatterns()
        {
            new Adapter().Run();
            new Bridge().Run();
            new Composite().Run();
            new Decorator().Run();
            new Facade().Run();
            new Flyweight().Run();
            new MarkerInterface().Run();
            new Module().Run();
            new Proxy().Run();
            new Twin().Run();
        }

        private static void RunBehavioralPatterns()
        {
            new Blackboard().Run();
            new ChainOfResponsibility().Run();
            new Command().Run();
            new Interpreter().Run();
            new Iterator().Run();
            new Mediator().Run();
            new Memento().Run();
            new NullObject().Run();
            new Observer().Run();
            new Servant().Run();
            new Specification().Run();
            new State().Run();
            new Strategy().Run();
            new Template().Run();
            new Visitor().Run();
        }
    }
}
