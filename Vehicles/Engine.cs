using System;
namespace Vehicles
{

    public abstract class Engine
    {
        private FuelType fuel;

        //FuleType zdefiniowane  w enumeracji znajdujacej sie w  FuelType.cs 
        // public pozwala na dostęp (zapisywanie i odczyt) do prywatnego pola fuel o typie FuelType
        public FuelType Fuel
        {
            get { return this.fuel; }
            set { this.fuel = value; }
        }
    }
}
