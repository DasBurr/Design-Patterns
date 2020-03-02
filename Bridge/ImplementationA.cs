using System;

namespace Bridge
{
    public class ImplementationA : IBridge
    {
        public void OperationImplementation()
        {
            Console.WriteLine("ImplementationA:OperationImplementation()");
        }
    }
}
