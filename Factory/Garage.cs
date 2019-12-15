using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class Garage
    {
        public Garage(string operation)
        {
            GarageFactory factory = null;

            switch (operation)
            {
                case "open":
                    factory = new GarageOpenFactory();
                    break;
                case "close":
                    factory = new GarageCloseFactory();
                    break;
                default:
                    break;
            }

            factory.Operate(true);
            factory.Operate(false);
        }
    }
}
