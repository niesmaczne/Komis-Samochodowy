using System;
namespace Vehicles
{
    public abstract class Engine
    {
        private FuelType fuel;

        public FuelType Fuel
        {
            get { return this.fuel; }
            set { this.fuel = value; }
        }
    }
}
