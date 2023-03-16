using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHFragBFTKlassenBibliothek
{
    internal class Feature6
    {
        internal static void feature_6()
        {
            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                              "|                 >>> Willkommen beim Physik Konverter <<<                         |\n" +
                              "------------------------------------------------------------------------------------\n\n");
            Console.WriteLine("Wählen Sie eine Option:");
            Console.WriteLine("1 - Meter in Kilometer umrechnen");
            Console.WriteLine("2 - Zentimeter in Meter umrechnen");
            Console.WriteLine("3 - Gramm in Kilogramm umrechnen");
            Console.WriteLine("4 - Millisekunden in Sekunden umrechnen\n");
            Console.Write("Bitte wählen sie eine Option: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Bitte geben Sie die Länge in Metern ein: ");
                    double meters = double.Parse(Console.ReadLine());
                    double kilometers = meters / 1000;
                    Console.WriteLine("{0} Meter entsprechen {1} Kilometer.", meters, kilometers);
                    break;

                case 2:
                    Console.Write("Bitte geben Sie die Länge in Zentimetern ein: ");
                    double centimeters = double.Parse(Console.ReadLine());
                    double meters2 = centimeters / 100;
                    Console.WriteLine("{0} Zentimeter entsprechen {1} Metern.", centimeters, meters2);
                    break;

                case 3:
                    Console.Write("Bitte geben Sie das Gewicht in Gramm ein: ");
                    double grams = double.Parse(Console.ReadLine());
                    double kilograms = grams / 1000;
                    Console.WriteLine("{0} Gramm entsprechen {1} Kilogramm.", grams, kilograms);
                    break;

                case 4:
                    Console.Write("Bitte geben Sie die Zeit in Millisekunden ein: ");
                    double milliseconds = double.Parse(Console.ReadLine());
                    double seconds = milliseconds / 1000;
                    Console.WriteLine("{0} Millisekunden entsprechen {1} Sekunden.", milliseconds, seconds);
                    break;

                default:
                    Console.WriteLine("Ungültige Option ausgewählt.");
                    break;
            Console.ReadKey();
            }
        }    
    }
}
