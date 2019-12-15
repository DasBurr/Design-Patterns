using System;

namespace Factory
{
    class GarageOpen : IGarage
    {
        private readonly bool _open;

        public GarageOpen(bool open)
        {
            _open = open;
        }

        public void Operate()
        {
            if (_open)
            {
                Console.WriteLine("Garage opening");
            }
            else
            {
                Console.WriteLine("Garage already opened");
            }
        }
    }
}
