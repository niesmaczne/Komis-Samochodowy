using System;
using Vehicles;

namespace BorskaBiskup_KomisSamochodowy
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Console.WriteLine(car1.Discount(5));
        }
    }
}
