using System;

namespace Vehicles
{
    public class Motorcycle: Vehicle, IDiscounter
    {
        public Motorcycle()
        {
        }

        public float Discount(int percentage)
        {
            this.Price = this.Price * (1 - ((float)percentage / 100));
            return this.Price;
        }
    }
}
