using Factory;
using System;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var garage = new Garage("open");
            Console.ReadKey();
        }
    }
}
