using System;

namespace Vehicles
{
    public class Motorcycle: Vehicle, IDiscounter
    {
        public Motorcycle(string brand, string name, int year, Engine engine, decimal price)
        {
            this.Brand = brand;
            this.Name = name;
            this.Year = year;
            this.Price = price;
            this.WheelsNumber = 2;
            this.Engine = engine;
        }

        public decimal Discount(int percentage)
        {
            this.Price = this.Price * (1 - ((decimal)percentage / 100));
            return this.Price;
        }

        override public string ToString()
        {
            return String.Format("Motorcycle: {0} {1} ({2})\n" +
                    "- Wheels: {0}\n" +
                    "- Engine: {1}\n"+
                    "- Price: ${2}\n",
                    this.Brand, this.Name, this.Year,
                    this.WheelsNumber,
                    this.Engine,
                    this.Price
                );
        }
    }
}
