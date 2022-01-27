using System;
namespace Vehicles
{
    public interface IDiscounter
    {
        public decimal Discount(int percentage);
    }
}
//interface z zdefiniowaną funkcją, kazda klasa dziedziczaca po tym w interfejsie musi miec ta funkcje discount zwracajaca decimal oraz przyjmujaca int; zwróci wartość po obnizce