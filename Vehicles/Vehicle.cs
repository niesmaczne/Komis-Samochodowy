using System;

namespace Vehicles
{
    public abstract class Vehicle: IDiscounter
    {
        //prywatne pola aby mogła poprawnie zajść hermetyzacja
        private string brand;
        private string name;
        private int year;
        private decimal price;
        private int wheels_number;

        public Engine Engine;

        //daje dostęp do prywatnego price, zarówno do zapisu jak i odczytu
        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public int WheelsNumber
        {
            get { return this.wheels_number; }
            set { this.wheels_number = value; }
        }

        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
        //pozwala uzyc vehicle jako discountera; jezeli chciałabym stworzyć instancje, to wyrzuci wyjatek
        public decimal Discount(int percentage) { throw new NotImplementedException(); }
    }
}
