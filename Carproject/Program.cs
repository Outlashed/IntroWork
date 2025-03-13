using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

namespace Carproject
{

    internal class Program
    {
            static string Brand;
            static string Model;
            static int Year;
            static int Km;
            static char Geartype;
            static char FuelType;
            static double KmPerLiter;
            static double FuelPrice;
            static double Distance;
            static double FuelNeeded;
            static double TripCost;
            static bool isEngineOn = false;
            static List<string> CarStringList = new List<string>();



            static void Main(string[] args)
            {

                bool running = true;


                while (running)
                {
                    Console.WriteLine();
                    Console.WriteLine("0. Start motor");
                    Console.WriteLine("1. Indtast Oplysninger");
                    Console.WriteLine("2. Køretur");
                    Console.WriteLine("3. Hvad koster en køretur?");
                    Console.WriteLine("4. Ispalindrome");
                    Console.WriteLine("5. Print car details");
                    Console.WriteLine("6. Afslut");
                    Console.WriteLine(" skriv 1-6 for at vælge en valgmulighed");
                    Console.WriteLine();

                    int Userinput = Convert.ToInt32(Console.ReadLine());



                    switch (Userinput)
                    {
                        case 0:
                            isEngineOn = StartEngine(isEngineOn);
                            break;

                        case 1:
                            ReadCarDetails();
                            break;

                        case 2:
                            Km = Drive(isEngineOn, Km);
                            break;

                        case 3:
                            FuelNeeded = CalculateFuelNeeded(Distance, KmPerLiter);
                            TripCost = CalculateTripCost(FuelNeeded, FuelPrice);
                            Console.WriteLine($"Der skal bruges {FuelNeeded:F2}L for at køre {Distance} km. Turen vil koste {TripCost:C} ");
                            break;

                        case 4:
                            bool isPalindrome = IsPalindrome(Km);
                            Console.WriteLine($"Kilometerstanden ({Km}) er {(isPalindrome ? "" : "ikke ")}et palindrom!");
                            break;

                        case 5:
                            PrintCarDetails(Brand, Model, Year, Km, Geartype, FuelType, FuelPrice);
                            break;
                        case 6:
                            running = false;
                            break;
                    }
                }

                static bool StartEngine(bool engineStatus)
                {

                    bool newStatus = !engineStatus;
                    Console.WriteLine(newStatus ? "Bilen er nu tændt!" : "Bilen er nu slukket!");
                    return newStatus;
                }

                static void ReadCarDetails()
                {


                    Console.Write("Indtast bilens mærke: ");
                    Brand = Console.ReadLine();

                    Console.Write("Indtast bilens model: ");
                    Model = Console.ReadLine();

                    Console.Write("Indtast bilens årgang: ");
                    Year = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Indtast bilens kilometerstan: ");
                    Km = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Indtast geartype (A for automatisk, M for manuel): ");
                    Geartype = Console.ReadLine()[0];
                    Console.WriteLine("Du indtastede bilen har: " + " " + Geartype);

                    Console.Write("Indtast bilens brændstoftype: ");
                    FuelType = Char.ToUpper(Console.ReadLine()[0]);
                    if (FuelType == 'B')
                    {

                        FuelPrice = 14.5;
                    }
                    else if (FuelType == 'D')
                    {
                        FuelPrice = 12.9;
                    }
                    else
                    {
                        Console.Write("Ukendt brændstoftype indskriv brændstof pris manuelt: ");
                        FuelPrice = Convert.ToDouble(Console.ReadLine());
                    }

                    Console.WriteLine($"Du indtastede brændstoftypen som værende: {FuelType}");


                    Console.Write("Indtast bilens km/l: ");
                    KmPerLiter = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Du indtastede bilens km liter er:" + " " + KmPerLiter);

                    CarStringList.Add($"Mærke: {Brand} Model: {Model} Årgang: {Year} Kilometerstand: {Km} Geartype: {Geartype} Brændstoftype: {FuelType}");

                }

                static int Drive(bool engineStatus, int totalKm)
                {
                    if (!engineStatus)
                    {
                        Console.WriteLine("Start motoren først!");
                        return totalKm; // No change to Km
                    }
                    else
                    {
                        Console.Write("Hvor langt vil du køre? (km): ");
                        Distance = Convert.ToDouble(Console.ReadLine());
                        return totalKm + (int)Distance;
                    }

                }

                static double CalculateFuelNeeded(double distance, double kmPerLiter)
                {
                    if (kmPerLiter <= 0)
                    {
                        Console.Write("Indtast km/l (må ikke være 0): ");
                        KmPerLiter = Convert.ToDouble(Console.ReadLine());
                        kmPerLiter = KmPerLiter; // Update parameter with new global value
                    }
                    return distance / kmPerLiter;
                }

                static double CalculateTripCost(double fuelNeeded, double fuelPrice)
                {
                    return fuelNeeded * fuelPrice;
                }

                static bool IsPalindrome(int number)
                {
                    int original = number;
                    int reversed = 0;
                    while (number > 0)
                    {
                        int digit = number % 10;
                        reversed = reversed * 10 + digit;
                        number /= 10;
                    }
                    return original == reversed;
                }

                static void PrintCarDetails(string brand, string model, int year, int km,
                                       char gearType, char fuelType, double fuelPrice)
                {
                    string details = $"Mærke: {brand}, Model: {model}, Årgang: {year}, Km: {km}, Geartype: {gearType}, Brændstoftype: {fuelType}, Brændstofpris: {fuelPrice:F2} kr";
                    Console.WriteLine(details);
                }
                    }
                }

            }
        







/*
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
*/
