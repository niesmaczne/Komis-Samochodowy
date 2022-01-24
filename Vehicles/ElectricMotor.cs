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

        public ElectricMotor(double power, int range)
        {
            this.Range = range;
            this.Power = power;
            this.Fuel = FuelType.Electricity;
        }

        override public string ToString()
        {
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
