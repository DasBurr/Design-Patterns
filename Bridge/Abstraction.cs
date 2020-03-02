using System;

namespace Bridge
{
    public abstract class Abstraction
    {
        public IBridge Implementer { get; set; }

        public virtual void Operation()
        {
            Console.WriteLine("ImplementationBase:Operation()");
            Implementer.OperationImplementation();
        }
    }
}
