using System;
namespace Vehicles
{
    public class Car: Vehicle, IDiscounter
    {
        public Car()
        {
            this.Price = 100.0F;
        }

        public float Discount(int percentage)
        {
            this.Price = this.Price * (1 - ((float)percentage / 100));

            return this.Price;
        }
    }
}
