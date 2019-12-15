using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class GarageCloseFactory : GarageFactory
    {
        public override IGarage Operate(bool operate) => new GarageClose(operate);
    }
}
