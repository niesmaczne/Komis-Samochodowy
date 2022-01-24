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
