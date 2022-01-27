using System;
namespace Vehicles
{
    public class ElectricMotor: Engine
    {
        private double power;
        private int range;

        public double Power
        {
            get { return this.power; }
            set { this.power = value; }
        }

        public int Range
        {
            get { return this.range; }
            set { this.range = value; }
        }

        //uzycie set z hermetyzacji
        public ElectricMotor(double power, int range)
        {
            this.Range = range;
            this.Power = power;
            this.Fuel = FuelType.Electricity;
        }
        //uzycie get z hermetyzacji
        override public string ToString()
        {
            // funkcja tosring nadpisuje domyslna funkcje tostring aby ladnie przetransformowac klase na string (inaczej zwrocilby domyslna wartosc)
        // dziedziczenie po klasie w ktorej jest juz zdefiniowana dana funkcja wymusza uzycide slowa override zeby nadpisac dana funkcje 
            return String.Format("Electric Motor:\n" +
                    "\t- Power: {0} kW\n" +
                    "\t- Fuel Type: {1}\n"+
                    "\t- Range: {2} km",
                    this.Power,
                    this.Fuel,
                    this.Range
                );
        }
    }
}
