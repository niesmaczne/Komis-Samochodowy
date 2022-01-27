using System;
namespace Vehicles
{
    public class InternalCombustionEngine: Engine
    {
        private int pistons;
        private double size;
        private double power;

        public int Pistons
        {
            get { return this.pistons; }
            set { this.pistons = value; }
        }

        public double Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public double Power
        {
            get { return this.power; }
            set { this.power = value; }
        }

        public InternalCombustionEngine(int pistons, double size, double power, FuelType fuel)
        {
            this.Pistons = pistons;
            this.Size = size;
            this.Power = power;
            this.Fuel = fuel;
        }
        
        // funkcja tosring nadpisuje domyslna funkcje tostring aby ladnie przetransformowac klase na string (inaczej zwrocilby domyslna wartosc)
        // dziedziczenie po klasie w ktorej jest juz zdefiniowana dana funkcja wymusza uzycide slowa override zeby nadpisac dana funkcje 
        override public string ToString()
        {
            return String.Format("Internal Combustion Engine:\n" +
                    "\t- Power: {0} kW\n" +
                    "\t- Fuel Type: {1}\n" +
                    "\t- Size: {2} L\n" +
                    "\t- Pistons: {3}",
                    this.Power,
                    this.Fuel,
                    this.Size,
                    this.Pistons
                );
        }
    }
}
