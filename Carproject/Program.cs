using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

namespace Carproject
{

    internal class Program
    {


        static void Main(string[] args)
        {

            // Dette gør at der er nogle viste instruktioner til input, således at brugeren kan LÆSE hvad de skal svare på.
            Console.Write("Indtast bilmærke: ");

            // vi definerer hvad <brand> er.
            string brand = Console.ReadLine();

            // vi definerer hvad <model> er
            Console.Write("Indtast bilmodel: ");
            string model = Console.ReadLine();

            // vi definerer hvad <year> er
            Console.Write("Indtast årgang: ");
            int year = Convert.ToInt32(Console.ReadLine());

            // vi definerer hvad <geartype> bilen er
            Console.WriteLine(@"Indtast geartype:
            Skriv A for Automatgear
            Skriv M for Manuelt");
            char gearType = Console.ReadLine()[0];


            // Vi definerer hvad <fueltype> er
            Console.WriteLine(@"Indtast Brændstoftype:
            Tast D for Diesel
            Tast B for Benzin");
            char fueltype = Console.ReadLine()[0];

            // Vi definerer <fuelPrice> | 13.49kr/L for Benzin | 12.29 kr/L for Diesel |
            double fuelPrice;
            if (fueltype == 'B')
            {
                fuelPrice = 13.49;
            }
            else
            {
                fuelPrice = 12.29;
            }

            // vi definerer hvad <kmPerLiter> er
            Console.WriteLine("Indtast hvor mange kilometer bilen kører per liter");
            float kmPerLiter = float.Parse(Console.ReadLine());

            // Vi definerer den nuværende <kilometerstand>
            Console.WriteLine("Indtast nuværende kilometerstand");
            float CurrentKM = float.Parse(Console.ReadLine());

            // Vi definerer <distance>
            Console.WriteLine("Indtast rejsedistance i km");
            float distance = float.Parse(Console.ReadLine());

            // Vi lægger <CurrentKM> sammen med <Distance>
            float TotalKM = CurrentKM + distance;

            // vi definerer <fuelNeeded>
            double fuelNeeded = distance / kmPerLiter;
            fuelNeeded = Math.Round(fuelNeeded, 2);

            // Vi definerer <tripCost>
            double tripCost = fuelNeeded * fuelPrice;
            tripCost = Math.Round(tripCost, 2);


            string.Format($"Brændstofsudgifterne for {distance}km er {tripCost}");

            // Headers Tabel 1

            // Headers 
            Console.WriteLine("| {0} | {1} | {2} |",
                "Bilmærke".PadRight(20),
                "Model".PadRight(20),
                "Kilometertal".PadRight(20));

            Console.WriteLine(new string('-', 20 + 20 + 20 + 10));

            // Data Tabel 1
            Console.WriteLine("| {0} | {1} | {2} |",
                $"{brand}".PadRight(20),
                $"{model}".PadRight(20),
                $"{year}".PadRight(20));

            Console.WriteLine();

            // Headers Tabel 2

            Console.WriteLine("| {0} | {1} | {2} |",
                "Nuværende KM".PadRight(20),
                "Rejsedistance".PadRight(20),
                "Slut KM".PadRight(20));

            // Data Tabel 2
            Console.WriteLine("| {0} | {1} | {2} |",
                $"{CurrentKM}".PadRight(20),
                $"{distance}".PadRight(20),
                $"{TotalKM}".PadRight(20));

            Console.WriteLine();
            Console.WriteLine("------------------------------ Forskellige biler ---------------------");

            // Header Tabel 3
            Console.WriteLine("| {0} | {1} | {2} |",
                "Producent".PadRight(20),
                "Model".PadRight(20),
                "Årgang".PadRight(20));

            Console.WriteLine(new string('-', 20 + 20 + 20 + 10));

            // Data Tabel 3
            Console.WriteLine("| {0} | {1} | {2} |",
                "Ford".PadRight(20),
                "Fiesta".PadRight(20),
                "2004".PadRight(20));

            Console.WriteLine("| {0} | {1} | {2} |",
                "Toyota".PadRight(20),
                "Corolla".PadRight(20),
                "2002".PadRight(20));

            Console.WriteLine("| {0} | {1} | {2} |",
                "Hyundai".PadRight(20),
                "Getz".PadRight(20),
                "2019".PadRight(20));

            Console.WriteLine("| {0} | {1} | {2} |",
                "Volkswagen".PadRight(20),
                "Up".PadRight(20),
                "2025".PadRight(20));
        }
    }
}
