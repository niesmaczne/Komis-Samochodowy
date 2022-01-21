using System;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private float price;

        public float Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
    }
}
