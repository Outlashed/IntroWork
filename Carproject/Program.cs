using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

namespace Carproject
{

    internal class Program
    {
        private const string V = "Manuelt gear";

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
            CurrentKM = CurrentKM + distance;

            // vi definerer <fuelNeeded>
            double fuelNeeded = distance / kmPerLiter;
            fuelNeeded = Math.Round(fuelNeeded, 2);

            // Vi definerer <tripCost>
            double tripCost = fuelNeeded * fuelPrice;
            tripCost = Math.Round(tripCost, 2);


            Console.WriteLine($"Din bil: {brand} {model} fra {year} med {gearType}");
            Console.WriteLine($"Da din bil er {fueltype} er liter-prisen {fuelPrice}");
            Console.WriteLine($"Rejsedistance: {distance}");
            Console.WriteLine($"Din pris for rejsen er ({distance}km / {fuelNeeded}km) x {fuelPrice} = {tripCost} ");
            Console.WriteLine($"din nye kilometerstand efter rejsen: {CurrentKM}");

            // Vi definerer <tripCost> for rejsen
            //double tripCost = fuelNeeded * fuelPrice;

            //Console.WriteLine(tripcost);




            // Her vil vi gerne have at den skal skrive en sætning med informationen
            //   Console.WriteLine($"Din bil er en {brand} {model} {year} med geartype {gearType}");

            // Her vil vi gerne have den til at gøre noget, baseret på svar givet ved bilens årgang.
            //   if (year <= 2020)
            {
                // Hvis bilen er fra 2020 eller ældre - Skal den skrive følgende besked.
                //     Console.WriteLine("Fordi din bil er minimum end 5 år gammel, husk at tjekke oliefilter.");
            }
                    // Ellers skal den skrive følgende besked.
         // else
            {
         //     Console.WriteLine("Din bil er nyere end 5 år, så dit oliefilter skal ikke skiftes");

            }


        }
    }
}
