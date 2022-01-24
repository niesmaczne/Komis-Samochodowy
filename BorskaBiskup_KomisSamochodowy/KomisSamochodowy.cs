using System;
using System.Collections.Generic;
using Vehicles;

namespace BorskaBiskup_KomisSamochodowy
{
    public class KomisSamochodowy
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

        public KomisSamochodowy()
        {
            vehicles.Add(new Car("VolksWagen", "Golf", 1994,
                new InternalCombustionEngine(4, 1.4, 86.2, FuelType.Diesel),
                1000M));

            vehicles.Add(new Car("Audi", "TT", 2001,
                new InternalCombustionEngine(6, 2.4, 144.3, FuelType.Gasoline),
                1344.32M));


            vehicles.Add(new Car("BMW", "i3", 2013,
                new ElectricMotor(60.3, 120),
                1622.42M));
        }

        public void MainMenu()
        {
            string s_input;
            int i_input;

            while (true)
            {
                Console.Write("Witaj w komisie!\n\n" +
                    "Co chcesz zrobić?\n" +
                    "1. Wyświetl pojazdy\n" +
                    "2. Dodaj pojazd\n" +
                    "0. Wyjdź z programu\n");

                s_input = Console.ReadLine();
                try
                {
                    i_input = Int32.Parse(s_input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Zła akcja!");
                    continue;
                }

                switch (i_input)
                {
                    case 0:
                        Console.WriteLine("Żegnaj!");
                        return;

                    case 1:
                        printVehicles();
                        break;

                    case 2:
                        addVehicle();
                        break;

                    default:
                        Console.WriteLine("Zła akcja!");
                        continue;
                }
            }
        }

        private void addVehicle()
        {
            string s_input;
            int i_input;

            while (true)
            {
                Console.Write("Jaki pojazd chcesz dodać?\n" +
                    "1. Samochód\n" +
                    "2. Motocykl\n" +
                    "0. Anuluj\n");

                s_input = Console.ReadLine();
                try
                {
                    i_input = Int32.Parse(s_input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Zła akcja!");
                    continue;
                }

                switch (i_input)
                {
                    case 0:
                        return;

                    case 1:
                        this.vehicles.Add(readCar());
                        break;

                    case 2:
                        this.vehicles.Add(readMotorcycle());
                        break;

                    default:
                        Console.WriteLine("Zła akcja!");
                        continue;
                }
            }

        }

        private Car readCar()
        {
            string s_input;
            string brand;
            string name;
            int year;
            decimal price;

            while (true)
            {
                Console.WriteLine("Podaj markę");
                brand = Console.ReadLine();

                Console.WriteLine("Podaj nazwę");
                name = Console.ReadLine();


                Console.WriteLine("Podaj rok produkcji");

                s_input = Console.ReadLine();
                try
                {
                    year = Int32.Parse(s_input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Zła akcja!");
                    continue;
                }

                Console.WriteLine("Podaj cenę");

                s_input = Console.ReadLine();
                try
                {
                    price = Decimal.Parse(s_input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Zła akcja!");
                    continue;
                }

                return new Car(brand, name, year, readEngine(), price);
            }
        }

        private Motorcycle readMotorcycle()
        {
            string s_input;
            string brand;
            string name;
            int year;
            decimal price;

            while (true)
            {
                Console.WriteLine("Podaj markę");
                brand = Console.ReadLine();

                Console.WriteLine("Podaj nazwę");
                name = Console.ReadLine();


                Console.WriteLine("Podaj rok produkcji");

                s_input = Console.ReadLine();
                try
                {
                    year = Int32.Parse(s_input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Zła akcja!");
                    continue;
                }

                Console.WriteLine("Podaj cenę");

                s_input = Console.ReadLine();
                try
                {
                    price = Decimal.Parse(s_input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Zła akcja!");
                    continue;
                }

                return new Motorcycle(brand, name, year, readEngine(), price);
            }
        }

        private Engine readEngine()
        {
            string s_input;
            int i_input;

            while (true)
            {
                Console.Write("Wybierz rodzaj silnika:\n" +
                    "1. Internal Combustion Engine\n" +
                    "2. Electric Motor\n");

                s_input = Console.ReadLine();
                try
                {
                    i_input = Int32.Parse(s_input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Zła akcja!");
                    continue;
                }

                switch (i_input)
                {
                    case 1:
                        return readICE();
                    case 2:
                        return readElectricMotor();

                    default:
                        Console.WriteLine("Zła akcja!");
                        continue;
                }
            }
        }

        private InternalCombustionEngine readICE()
        {
            string s_input;
            int i_input;
            int pistons;
            double size;
            double power;
            FuelType fuel;

            while (true)
            {
                Console.WriteLine("Podaj ilość cylindrów");

                s_input = Console.ReadLine();
                try
                {
                    pistons = Int32.Parse(s_input);
                    if (pistons <= 0)
                    {
                        throw new FormatException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Zła ilość cylindrów!");
                    continue;
                }

                Console.WriteLine("Podaj pojemność silnika");

                s_input = Console.ReadLine();
                try
                {
                    size = Double.Parse(s_input);
                    if (size <= 0.0)
                    {
                        throw new FormatException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Zła pojemność!");
                    continue;
                }

                Console.WriteLine("Podaj moc silnika");

                s_input = Console.ReadLine();
                try
                {
                    power = Double.Parse(s_input);
                    if (power <= 0.0)
                    {
                        throw new FormatException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Zła moc!");
                    continue;
                }

                Console.Write("Wybierz rodzaj paliwa:\n" +
                    "{0}. {1}\n" +
                    "{2}. {3}\n" +
                    "{4}. {5}\n" +
                    "{6}. {7}\n" +
                    "{8}. {9}\n",
                    /*0*/ FuelType.Diesel.ToString("d"), FuelType.Diesel,
                    /*2*/ FuelType.Gasoline.ToString("d"), FuelType.Gasoline,
                    /*4*/ FuelType.Hydrogen.ToString("d"), FuelType.Hydrogen,
                    /*6*/ FuelType.NaturalGas.ToString("d"), FuelType.NaturalGas,
                    /*8*/ FuelType.Biofuel.ToString("d"), FuelType.Biofuel);

                s_input = Console.ReadLine();
                try
                {
                    i_input = Int32.Parse(s_input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Zły rodzaj paliwa!");
                    continue;
                }

                switch (i_input)
                {
                    case 1:
                        fuel = FuelType.Diesel;
                        break;

                    case 2:
                        fuel = FuelType.Gasoline;
                        break;

                    case 3:
                        fuel = FuelType.Hydrogen;
                        break;

                    case 4:
                        fuel = FuelType.NaturalGas;
                        break;

                    case 5:
                        fuel = FuelType.Biofuel;
                        break;

                    default:
                        Console.WriteLine("Zły rodzaj paliwa!");
                        continue;
                }

                return new InternalCombustionEngine(pistons, size, power, fuel);
            }
        }

        private ElectricMotor readElectricMotor()
        {
            string s_input;
            double power;
            int range;

            while (true)
            {
                Console.WriteLine("Podaj moc silnika");

                s_input = Console.ReadLine();
                try
                {
                    power = Double.Parse(s_input);
                    if (power <= 0.0)
                    {
                        throw new FormatException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Zła moc silnika!");
                    continue;
                }

                Console.WriteLine("Podaj zasięg z danym silnikiem");

                s_input = Console.ReadLine();
                try
                {
                    range = Int32.Parse(s_input);
                    if (range <= 0)
                    {
                        throw new FormatException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Zły zasięg!");
                    continue;
                }

                return new ElectricMotor(power, range);
            }
        }

        private void removeVehicle(Vehicle v) {
            bool ok = this.vehicles.Remove(v);
            if (!ok)
            {
                Console.WriteLine("Vehicle was not removed!");
            }
        }

        private void discountVehicle(IDiscounter v)
        {
            string s_input;
            int percentage;

            while (true)
            {
                Console.WriteLine("Podaj procent przeceny");

                s_input = Console.ReadLine();
                try
                {
                    percentage = Int32.Parse(s_input);
                    if (percentage > 100 || percentage < 0)
                    {
                        throw new FormatException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Zły procent!");
                    continue;
                }

                v.Discount(percentage);
                break;
            }
        }

        private void printVehicles()
        {
            bool empty = true;
            List<Vehicle> markedForDeletion = new List<Vehicle>();

            foreach (Vehicle v in vehicles)
            {
                empty = false;
                Console.WriteLine(v);
                string s_input;
                int i_input;

                bool done = false;
                while (!done)
                {
                    Console.Write("Co chcesz zrobić?\n" +
                        "1. Pokaż następny pojazd\n" +
                        "2. Przeceń pojazd\n" +
                        "3. Usuń pojazd\n" +
                        "0. Wróć\n");

                    s_input = Console.ReadLine();
                    try
                    {
                        i_input = Int32.Parse(s_input);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Zła akcja!");
                        continue;
                    }

                    switch (i_input)
                    {
                        case 0:
                            return;

                        case 1:
                            done = true;
                            break;

                        case 2:
                            discountVehicle(v);
                            done = true;
                            break;

                        case 3:
                            markedForDeletion.Add(v);
                            done = true;
                            break;

                        default:
                            Console.WriteLine("Zła akcja!");
                            continue;
                    }
                }
            }

            if (empty)
            {
                Console.WriteLine("Lista samochodów jest pusta!");
            }

            foreach (Vehicle marked in markedForDeletion)
            {
                removeVehicle(marked);
            }
        }
    }
}
