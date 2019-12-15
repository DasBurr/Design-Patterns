using System;

namespace Factory
{
    class GarageClose : IGarage
    {
        private readonly bool _close;

        public GarageClose(bool close)
        {
            _close = close;
        }

        public void Operate()
        {
            if (_close)
            {
                Console.WriteLine("Garage closing");
            }
            else
            {
                Console.WriteLine("Garage already closed");
            }            
        }
    }
}
