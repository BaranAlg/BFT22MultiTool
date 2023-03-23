using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIBFTKlassenBibliothek
{
    internal class Feature18
    {
        internal static void Feature_18()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Willkommen beim Immobilienrechner");

            Console.WriteLine("Geben Sie den Kaufpreis der Immobilie ein: ");
            double v = double.Parse(Console.ReadLine());
            double kaufpreis = v;

            Console.WriteLine("Geben Sie die Laufzeit des Darlehens in Jahren ein: ");
            double v = double.Parse(Console.ReadLine());

            Console.WriteLine("Geben Sie den jährlichen als Dezimalzahl ein: ");
            double zinssatz = double.Parse(Console.ReadLine());

            {


                // Eingabeaufforderungen für Kaltmiete und Nebenkosten
                Console.WriteLine("Gib die Kaltmiete ein:");
                double kaltmiete = double.Parse(Console.ReadLine());

                Console.WriteLine("Gib die Nebenkosten ein:");
                double nebenkosten = double.Parse(Console.ReadLine());

                // Berechnung der Warmmiete
                double warmmiete = kaltmiete + nebenkosten;

                // Ausgabe der Ergebnisse
                Console.WriteLine($"Die Kaltmiete beträgt {kaltmiete:c}.");
                Console.WriteLine($"Die Nebenkosten betragen {nebenkosten:c}.");
                Console.WriteLine($"Die Warmmiete beträgt {warmmiete:c}.");

            }


            double darlehensbetrag = kaufpreis;
            double zinszahlungen = 0;

            for (int i = 0; i < laufzeit; i++)
            {
                zinszahlungen += darlehensbetrag * zinssatz;
                darlehensbetrag -= (kaufpreis / laufzeit);
            }

            double gesamtkosten = kaufpreis + zinszahlungen;
            Console.WriteLine($"Die Gesamtkosten der Immobilie betragen: {gesamtkosten} \u20AC");
        }
    }
}


