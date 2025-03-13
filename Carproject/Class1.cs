using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carproject
{
    internal class Car
    {
        private string brand;
        private string model;
        private int year;
        private double odometer;
        private char gearType;
        private char fuelType;
        private double kmPerLiter;
        private double fuelPrice;
        private double distance;
        private double fuelNeeded;
        private double tripCost;
        private bool isEngineOn = false;

        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public double Odometer { get => odometer; set => odometer = value; }
        public char GearType { get => gearType; set => gearType = value; }
        public char FuelType { get => fuelType; set => fuelType = value; }
        public double KmPerLiter { get => kmPerLiter; set => kmPerLiter = value; }
        public double FuelPrice { get => fuelPrice; set => fuelPrice = value; }
        public double Distance { get => distance; set => distance = value; }
        public double FuelNeeded { get => fuelNeeded; set => fuelNeeded = value; }
        public double TripCost { get => tripCost; set => tripCost = value; }
        public bool IsEngineOn1 { get => isEngineOn; set => isEngineOn = value; }

        public bool IsEngineOn(bool engineStatus)
        {
            bool newStatus = !engineStatus;
            Console.WriteLine(newStatus ? "\nEngine is running!\n" : "\nEngine is turned off!\n");
            IsEngineOn1 = newStatus;
            return newStatus;
        }

    }
}

