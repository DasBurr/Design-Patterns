namespace Singleton
{
    class Calculator
    {
        private static Calculator calculate = null;
        public static Calculator Instance
        {
            get
            {
                if (calculate == null)
                {
                    calculate = new Calculator();
                }
                return calculate;
            }
        }
        public double ValueOne { get; set; }
        public double ValueTwo { get; set; }

        public double Add => ValueOne + ValueTwo;
    }
}
