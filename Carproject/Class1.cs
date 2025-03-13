using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carproject
{
    internal class Car
    {
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public int Km { get; private set; }
        public char GearType { get; private set; }
        public char FuelType { get; private set; }
        public double KmPerLiter { get; private set; }
        public double FuelPrice { get; private set; }

        // Konstruktør
        public Car(string brand, string model, int year, int km, char gearType, char fuelType, double kmPerLiter, double fuelPrice)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Km = km;
            GearType = Char.ToUpper(gearType);
            FuelType = Char.ToUpper(fuelType);
            if (kmPerLiter > 0)
            {
                KmPerLiter = kmPerLiter;
            }
            else
            {
                throw new ArgumentException("Din Km/L skal være større end 0.");
            }

            if (fuelPrice >= 0)
            {
                FuelPrice = fuelPrice;
            }
            else
            {
                throw new ArgumentException("Brændstofprisen kan ikke være negativ.");
            }
        }

        // Metode til at simulere en køretur
        public void Drive(int distance)
        {
            if (distance > 0)
            {
                Km += distance;
            }
            else
            {
                Console.WriteLine("Distance skal være større end 0.");
            }
        }

        // Beregner hvor meget brændstof der skal bruges til en tur
        public double CalculateFuelNeeded(double distance)
        {
            return distance / KmPerLiter;
        }

        // Beregner prisen for en køretur
        public double CalculateTripCost(double distance)
        {
            return CalculateFuelNeeded(distance) * FuelPrice;
        }

        // Udskriver bilens detaljer
        public void PrintCarDetails()
        {
            Console.WriteLine($"Mærke: {Brand}, Model: {Model}, Årgang: {Year}, Km: {Km}, Geartype: {GearType}, Brændstoftype: {FuelType}, Brændstofpris: {FuelPrice:F2} kr");
        }
    }
}

