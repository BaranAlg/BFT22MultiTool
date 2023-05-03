using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("+------------------------------------------------+\n" +
                                  "|                                                |\n" +
                                  "|        Willkommen beim Physik Konverter        |\n" +
                                  "|                                                |\n" +
                                  "+------------------------------------------------+\n" +
                                  "|                                                |\n" +
                                  "|     Eingabe: exit  ->  beendet das Programm    |\n" +
                                  "|                                                |\n" +
                                  "|     1. Meter in Kilometer umrechnen            |\n" +
                                  "|     2. Zentimeter in Meter umrechnen           |\n" +
                                  "|     3. Gramm in Kilogramm umrechnen            |\n" +
                                  "|     4. Millisekunden in Sekunden umrechnen     |\n" +
                                  "|                                                |\n" +
                                  "+------------------------------------------------+\n");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Bitte wählen sie eine Option: ");
                Console.ResetColor();
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("+----------------------------------------------+\n" +
                                          "|                                              |\n" +
                                          "|         Meter in Kilometer umrechnen         |\n" +
                                          "|                                              |\n" +
                                          "+----------------------------------------------+\n" +
                                          "|                                              |\n" +
                                          "| Info:                                        |\n" +
                                          "|                                              |\n" +
                                          "| Die Einheit Kilometer gehört zum metrischen  |\n" +
                                          "| System und leitet sich von der Basiseinheit  |\n" +
                                          "| Meter ab. Dabei entspricht 1 Kilometer       |\n" +
                                          "| 1.000 Metern bzw. 1 Meter entspricht 0,001   |\n" +
                                          "| Kilometer.                                   |\n" +
                                          "|                                              |\n" +
                                          "+----------------------------------------------+\n");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Bitte geben Sie die Länge in Metern ein: ");
                        Console.ResetColor();
                        string input = Console.ReadLine();
                        if (input.ToLower() == "exit")
                        {
                            Environment.Exit(0);
                        }
                        else if (input.ToLower() == "subexit")
                        {
                            return;
                        }
                        else if (double.TryParse(input, out double meters))
                        {
                            double kilometers = meters / 1000;
                            Console.WriteLine($"{meters} Meter entsprechen {kilometers} Kilometer.");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein");
                            Console.ResetColor();
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("+----------------------------------------------+\n" +
                                          "|                                              |\n" +
                                          "|        Zentimeter in Meter umrechnen         |\n" +
                                          "|                                              |\n" +
                                          "+----------------------------------------------+\n" +
                                          "|                                              |\n" +
                                          "| Info:                                        |\n" +
                                          "|                                              |\n" +
                                          "| Der Meter ist die Basiseinheit der           |\n" +
                                          "| Länge im Internationalen Einheitensystem     |\n" +
                                          "| und in anderen metrischen Einheitensystemen. |\n" +
                                          "| Ein Meter ist seit 1983 definiert als die    |\n" +
                                          "| Länge der Strecke, die das Licht im Vakuum   |\n" +
                                          "| während der Dauer von 1/299 792 458          |\n" +
                                          "| Sekunde zurücklegt.                          |\n" +
                                          "|                                              |\n" +
                                          "+----------------------------------------------+\n");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Bitte geben Sie die Länge in Zentimetern ein: ");
                        Console.ResetColor();
                        string input1 = Console.ReadLine();
                        if (input1.ToLower() == "exit")
                        {
                            Environment.Exit(0);
                        }
                        else if (input1.ToLower() == "subexit")
                        {
                            return;
                        }
                        else if (double.TryParse(input1, out double centimeters))
                        {
                            double meters2 = centimeters / 100;
                            Console.WriteLine($"{centimeters} Zentimeter entsprechen {meters2} Metern.");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein");
                            Console.ResetColor();
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("+----------------------------------------------+\n" +
                                          "|                                              |\n" +
                                          "|          Gram in Kilogram umrechnen          |\n" +
                                          "|                                              |\n" +
                                          "+----------------------------------------------+\n" +
                                          "|                                              |\n" +
                                          "| Info:                                        |\n" +
                                          "|                                              |\n" +
                                          "| Das Kilogramm ist die im internationalen     |\n" +
                                          "| verwendete Maßeinheit für die Masse.         |\n" +
                                          "| Das Einheitenzeichen des Kilogramms ist kg.  |\n" +
                                          "| Die Definition des Kilogramms basiert auf    |\n" +
                                          "| einem zahlenmäßig festgelegten Wert der      |\n" +
                                          "| Planckschen Konstanten und den Definitionen  |\n" +
                                          "| von Meter und Sekunde.                       |\n" +
                                          "|                                              |\n" +
                                          "+----------------------------------------------+\n");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Bitte geben Sie das Gewicht in Gramm ein: ");
                        Console.ResetColor();
                        string input2 = Console.ReadLine();
                        if (input2.ToLower() == "exit")
                        {
                            Environment.Exit(0);
                        }
                        else if (input2.ToLower() == "subexit")
                        {
                            return;
                        }
                        else if (double.TryParse(input2, out double grams))
                        {
                            double kilograms = grams / 1000;
                            Console.WriteLine($"{grams} Gramm entsprechen {kilograms} Kilogramm.", grams, kilograms);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein");
                            Console.ResetColor();
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("+----------------------------------------------+\n" +
                                          "|                                              |\n" +
                                          "|     Millisekunden in Sekunden umrechnen      |\n" +
                                          "|                                              |\n" +
                                          "+----------------------------------------------+\n" +
                                          "|                                              |\n" +
                                          "| Info:                                        |\n" +
                                          "|                                              |\n" +
                                          "| Die Sekunde ist die SI-Basiseinheit der      |\n" +
                                          "| Zeit. Die Unterteilung der Stunde in 60      |\n" +
                                          "| Minuten zu je 60 Sekunden findet sich        |\n" +
                                          "| bereits um das Jahr 1000 in einer Schrift    |\n" +
                                          "| von al-Bīrūnī. Als Secunda von lateinisch    |\n" +
                                          "| pars minuta secunda ist sie seit dem         |\n" +
                                          "| 13. Jahrhundert bekannt.                     |\n" +
                                          "|                                              |\n" +
                                          "+----------------------------------------------+\n");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Bitte geben Sie die Zeit in Millisekunden ein: ");
                        Console.ResetColor();
                        string input3 = Console.ReadLine();
                        if (input3.ToLower() == "exit")
                        {
                            Environment.Exit(0);
                        }
                        else if (input3.ToLower() == "subexit")
                        {
                            return;
                        }
                        else if (double.TryParse(input3, out double milliseconds))
                        {
                            double seconds = milliseconds / 1000;
                            Console.WriteLine($"{milliseconds} Millisekunden entsprechen {seconds} Sekunden.");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein");
                            Console.ResetColor();
                        }
                        break;
                    case "exit":
                        Exit = true;
                        break;
                    default:

                        Console.WriteLine("Ungültige Eingabe");

                        (int, int) cPosAM = Console.GetCursorPosition();

                        KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);
                        break;
                        Console.ReadKey();
                }

            } while (!Exit);
        }
    }
}
