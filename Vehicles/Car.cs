using System;
namespace Vehicles
{
    public class Car: Vehicle, IDiscounter
    {
        public Car(string brand, string name, int year, Engine engine, decimal price)
        {
            this.Brand = brand;
            this.Name = name;
            this.Year = year;
            this.Price = price;
            this.WheelsNumber = 4;
            this.Engine = engine;
        }

        public decimal Discount(int percentage)
        {
            this.Price = this.Price * (1 - ((decimal)percentage / 100));

            return this.Price;
        }

        override public string ToString()
        {
            return String.Format("Car: {0} {1} ({2})\n" +
                    "- Wheels: {3}\n" +
                    "- Engine: {4}\n" +
                    "\t- Price: ${5}\n",
                    this.Brand, this.Name, this.Year,
                    this.WheelsNumber,
                    this.Engine,
                    this.Price
                );
        }
    }
}
