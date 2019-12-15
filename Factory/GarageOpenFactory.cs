namespace Factory
{
    class GarageOpenFactory : GarageFactory
    {
        public override IGarage Operate(bool operate) { var open = new GarageOpen(operate); open.Operate(); return open; }
    }
}
