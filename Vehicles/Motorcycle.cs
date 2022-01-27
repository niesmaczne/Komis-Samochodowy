using System;

namespace Vehicles
{
    public class Motorcycle: Vehicle, IDiscounter
    {
        //konstruktor car dla klasy car przyjmuje parametry na podstawie których wypełnia pola w klasie
        public Motorcycle(string brand, string name, int year, Engine engine, decimal price)
        {
            this.Brand = brand;
            this.Name = name;
            this.Year = year;
            this.Price = price;
            this.WheelsNumber = 2;
            this.Engine = engine;
        }

        // funkcja z interfejsu IDiscounter zmienia cenę samochodu o podany procent oraz zwraca cenę po zmianie 
        public decimal Discount(int percentage)
        {
            this.Price = this.Price * (1 - ((decimal)percentage / 100));
            return this.Price;
        }

        // funkcja tosring nadpisuje domyslna funkcje tostring aby ladnie przetransformowac klase na string (inaczej zwrocilby domyslna wartosc)
        // dziedziczenie po klasie w ktorej jest juz zdefiniowana dana funkcja wymusza uzycide slowa override zeby nadpisac dana funkcje 
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
