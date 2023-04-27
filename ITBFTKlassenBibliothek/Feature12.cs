using Figgle;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBFTKlassenBibliothek
{
    internal class Feature12
    {
        internal static void Feature_12()
        {
            

            Console.Clear();

            Console.WriteLine
                    (FiggleFonts.Slant.Render("DateiGrößenrechner XD"));

            
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Willkommen im Video- und Bilddateigrößenrechner!");
            Console.WriteLine("------------------------------------");
            int auswahl = 0;
            Console.WriteLine();
            do
            {
                Console.WriteLine("Was möchten Sie berechnen?");
                Console.WriteLine("1. Video-Dateigröße");
                Console.WriteLine("2. Bild-Dateigröße");
                Console.Write("Geben Sie die entsprechende Zahl ein (1 oder 2): ");

                string auswahlString = Console.ReadLine();

                if (!int.TryParse(auswahlString, out auswahl) || (auswahl != 1 && auswahl != 2))
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie entweder 1 oder 2 ein.");
                }
            } while (auswahl != 1 && auswahl != 2);

            int pixel = 0;
            int dpi = 0;

            do
            {
                Console.Write("Geben Sie die Pixelanzahl ein: ");
                string pixelString = Console.ReadLine();

                if (!int.TryParse(pixelString, out pixel) || pixel < 0)
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine positive Ganzzahl ein.");
                }
            } while (pixel < 0);

            do
            {
                Console.Write("Geben Sie die DPI (dots per inch) ein: ");
                string dpiString = Console.ReadLine();

                if (!int.TryParse(dpiString, out dpi) || dpi < 0)
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine positive Ganzzahl ein.");
                }
            } while (dpi < 0);

            double sizeInBytes = 0;

            if (auswahl == 1)
            {
                Console.Write("Geben Sie die Länge des Videos in Sekunden ein: ");
                string lengthString = Console.ReadLine();

                int lengthInSeconds = 0;
                if (!int.TryParse(lengthString, out lengthInSeconds) || lengthInSeconds < 0)
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine positive Ganzzahl ein.");
                    return;
                }

                sizeInBytes = pixel * pixel * dpi * dpi * lengthInSeconds * 3;
            }
            else
            {
                sizeInBytes = pixel * pixel * dpi * dpi * 3;
            }

            Console.WriteLine($"Die Dateigröße beträgt {sizeInBytes:N2} Bytes.");

            
            double ergebnis = 0;


            
            Console.WriteLine("Möchten Sie das Ergebnis in eine andere Einheit umrechnen?");
            Console.WriteLine("1. Byte");
            Console.WriteLine("2. Kilobyte");
            Console.WriteLine("3. Megabyte");
            Console.WriteLine("4. Gigabyte");
            Console.WriteLine("5. Nein");

            int umrechnungAuswahl = 0;
            do
        {
                Console.Write("Geben Sie die entsprechende Zahl ein (1-5): ");

                string umrechnungAuswahlString = Console.ReadLine();

                if (!int.TryParse(umrechnungAuswahlString, out umrechnungAuswahl) || (umrechnungAuswahl < 1 || umrechnungAuswahl > 5))
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl zwischen 1 und 5 ein.");
                }
            } while (umrechnungAuswahl < 1 || umrechnungAuswahl > 5) ;

            double umgerechneteGröße = sizeInBytes;

            switch (umrechnungAuswahl)
            {
                case 1: // Byte
                    Console.WriteLine("Die Dateigröße beträgt: " + umgerechneteGröße + " Bytes.");
                    break;

                case 2: // Kilobyte
                    umgerechneteGröße /= 1024;
                    Console.WriteLine("Die Dateigröße beträgt: " + umgerechneteGröße + " Kilobytes.");
                    break;

                case 3: // Megabyte
                    umgerechneteGröße /= 1024 * 1024;
                    Console.WriteLine("Die Dateigröße beträgt: " + umgerechneteGröße + " Megabytes.");
                    break;

                case 4: // Gigabyte
                    umgerechneteGröße /= 1024 * 1024 * 1024;
                    Console.WriteLine("Die Dateigröße beträgt: " + umgerechneteGröße + " Gigabytes.");
                    break;

                case 5: // Nein
                    Console.WriteLine("Vielen Dank für die Verwendung des Video- und Bilddateigrößenrechners!");
                    break;
            }

            Console.ReadLine();


        }
    }





}
