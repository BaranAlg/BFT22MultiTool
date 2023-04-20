using Figgle;
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
                                  "|                 >>> Willkommen beim Immobilienrechner <<<                         |\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t->\tbeendet das Programm\n\n");

                Console.WriteLine("1. Hypothekenzahlung");
                Console.Write("Bitte wählen sie eine Option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        // Eingabeaufforderungen für den Benutzer
                        Console.Write("Geben Sie den Kaufpreis des Hauses ein: ");
                        string input = Console.ReadLine();
                        if (input.ToLower() == "exit")
                        {
                            Environment.Exit(0);
                        }
                        else if (input.ToLower() == "subexit")
                        {
                            return; // Programm beenden
                        }
                        else if (double.TryParse(input, out double kaufpreis))
                        {
                            Console.Write("Geben Sie die Anzahlung ein: ");
                            string input1 = Console.ReadLine();
                            if (input.ToLower() == "exit")
                            {
                                Environment.Exit(0);
                            }
                            else if (input.ToLower() == "subexit")
                            {
                                return; // Programm beenden
                            }
                            else if (double.TryParse(input1, out double anzahlung))
                            {
                                Console.Write("Geben Sie den Zinssatz ein: ");
                                string input2 = Console.ReadLine();
                                if (input.ToLower() == "exit")
                                {
                                    Environment.Exit(0);
                                }
                                else if (input.ToLower() == "subexit")
                                {
                                    return; // Programm beenden
                                }
                                else if (double.TryParse(input2, out double zinssatz))
                                {
                                    Console.Write("Geben Sie die Laufzeit in Jahren ein: ");
                                    string input3 = Console.ReadLine();
                                    if (input.ToLower() == "exit")
                                    {
                                        Environment.Exit(0);
                                    }
                                    else if (input.ToLower() == "subexit")
                                    {
                                        return; // Programm beenden
                                    }
                                    else if (double.TryParse(input3, out double laufzeit))
                                    {
                                        // Berechnung der Hypothekenzahlung
                                        double darlehensbetrag = kaufpreis - anzahlung;
                                        double monatlicher_zins = zinssatz / 12 / 100;
                                        double laufzeit_in_monaten = laufzeit * 12;
                                        double zahlung = (darlehensbetrag * monatlicher_zins) / (1 - Math.Pow(1 + monatlicher_zins, -laufzeit_in_monaten));

                                        // Ausgabe der Hypothekenzahlung
                                        Console.WriteLine($"Die monatliche Hypothekenzahlung beträgt: {zahlung:F2} Euro");
                                        Console.ReadLine();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
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