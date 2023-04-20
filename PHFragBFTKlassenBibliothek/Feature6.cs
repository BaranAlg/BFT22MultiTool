using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace PHFragBFTKlassenBibliothek
{
    internal class Feature6
    {
        internal static void feature_6()
        {
            bool Exit = false;

            do
            {
                (int, int) cPosBM = Console.GetCursorPosition();

                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFT MultiTool"));

                //Konsolentitel wird geändert.
                Console.Title = "BFT MultiTool";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "|                 >>> Willkommen beim Physik Konverter <<<                         |\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t->\tbeendet das Programm\n\n");

                Console.WriteLine("1 - Meter in Kilometer umrechnen");
                Console.WriteLine("2 - Zentimeter in Meter umrechnen");
                Console.WriteLine("3 - Gramm in Kilogramm umrechnen");
                Console.WriteLine("4 - Millisekunden in Sekunden umrechnen\n");
                Console.Write("Bitte wählen sie eine Option: ");
                string option = Console.ReadLine();

                switch (option)

                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                          "|                      >>> Meter in Kilometer umrechen <<<                         |\n" +
                                          "------------------------------------------------------------------------------------\n\n");
                        Console.Write("Bitte geben Sie die Länge in Metern ein: ");
                        string input = Console.ReadLine();

                        if (input.ToLower() == "exit")
                        {
                            Environment.Exit(0);
                        }
                        else if (input.ToLower() == "subexit")
                        {
                            return; // Programm beenden
                        }
                        else if (double.TryParse(input, out double meters))
                        {
                            double kilometers = meters / 1000;
                            Console.WriteLine($"{meters} Meter entsprechen {kilometers} Kilometer.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                            break;
                        }
                        break;

                    case "2":
                        Console.Write("Bitte geben Sie die Länge in Zentimetern ein: ");
                        double centimeters = double.Parse(Console.ReadLine());
                        double meters2 = centimeters / 100;
                        Console.WriteLine($"{centimeters} Zentimeter entsprechen {meters2} Metern.");
                        break;

                    case "3":
                        Console.Write("Bitte geben Sie das Gewicht in Gramm ein: ");
                        double grams = double.Parse(Console.ReadLine());
                        double kilograms = grams / 1000;
                        Console.WriteLine($"{grams} Gramm entsprechen {kilograms} Kilogramm.");
                        break;

                    case "4":
                        Console.Write("Bitte geben Sie die Zeit in Millisekunden ein: ");
                        double milliseconds = double.Parse(Console.ReadLine());
                        double seconds = milliseconds / 1000;
                        Console.WriteLine($"{milliseconds} Millisekunden entsprechen {seconds} Sekunden.");
                        break;

                    case "exit":
                        Exit = true;
                        break;
                    default:
                        Console.WriteLine("Ungültige Option ausgewählt.");

                        (int, int) cPosAM = Console.GetCursorPosition();

                        KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);
                        break;
                        Console.ReadKey();
                }
            } while (!Exit);
        }    
    }
}
