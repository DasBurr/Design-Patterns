using System;

namespace Bridge
{
    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            Console.WriteLine("RefinedAbstraction:Operation()");
            Implementer.OperationImplementation();
        }
    }
}