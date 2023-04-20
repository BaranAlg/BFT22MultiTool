using Figgle;
using System;
using System.Collections.Generic;
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
                    (FiggleFonts.Slant.Render("BFTMultiTool"));

            Console.WriteLine("Videobreite und Bildbreite Berchnung");
            Console.WriteLine("------------------------------------");

            Console.WriteLine("Welche Berechnung möchten Sie durchführen?");
            Console.WriteLine("");
            Console.WriteLine("1 - Videobreite");
            Console.WriteLine("2 - Bildbreite");
            int auswahl = int.Parse(Console.ReadLine());

            double breite = 0;
            double hoehe = 0;
            double bildfrequenz = 0;

            switch (auswahl)
            {
                case 1:
                    Console.WriteLine("Geben Sie die Höhe des Videos in Pixeln ein:");
                    hoehe = double.Parse(Console.ReadLine());

                    Console.WriteLine("Haben Sie die Bildfrequenz in Hertz (fps)? (Ja/Nein)");
                    string eingabeFps = Console.ReadLine();
                    if (eingabeFps.ToLower() == "ja")
                    {
                        Console.WriteLine("Geben Sie die Bildfrequenz in Hertz ein:");
                        bildfrequenz = double.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Geben Sie die Dauer des Videos in Sekunden ein:");
                        double dauer = double.Parse(Console.ReadLine());
                        bildfrequenz = 30; 
                        if (dauer > 0)
                        {
                            bildfrequenz = 1 / dauer;
                        }
                    }

                    breite = hoehe * (16.0 / 9.0) * bildfrequenz * 4.0;
                    Console.WriteLine("Die Videobreite beträgt " + breite + " Pixel");
                    break;

                case 2:
                    Console.WriteLine("Geben Sie die Breite des Videos in Pixeln ein:");
                    breite = double.Parse(Console.ReadLine());

                    Console.WriteLine("Haben Sie die Bildfrequenz in Hertz (fps)? (Ja/Nein)");
                    eingabeFps = Console.ReadLine();
                    if (eingabeFps.ToLower() == "ja")
                    {
                        Console.WriteLine("Geben Sie die Bildfrequenz in Hertz ein:");
                        bildfrequenz = double.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Geben Sie die Dauer des Videos in Sekunden ein:");
                        double dauer = double.Parse(Console.ReadLine());
                        bildfrequenz = 30; 
                        if (dauer > 0)
                        {
                            bildfrequenz = 1 / dauer;
                        }
                    }

                    hoehe = breite / (16.0 / 9.0) / bildfrequenz / 4.0;
                    Console.WriteLine("Die Bildbreite beträgt " + breite + " Pixel und die Bildhöhe beträgt " + hoehe + " Pixel");
                    break;

                default:
                    Console.WriteLine("Ungültige Auswahl!");
                    break;
            }

            Console.WriteLine("Drücken Sie eine beliebige Taste, um das Programm zu beenden.");
            Console.ReadKey();



        }
    }





}
