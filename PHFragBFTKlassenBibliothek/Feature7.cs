using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PHFragBFTKlassenBibliothek
{
    internal class Feature7
    {
        internal static void feature_7()
        {
            bool Exit = false;
            do
            {
                (int, int) cPosBM = Console.GetCursorPosition();
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "|                     >>> Willkommen zum Schwerkraft-Rechner! <<<                  |\n" +
                                  "------------------------------------------------------------------------------------\n\n");
                Console.WriteLine("Eingabe: exit\t->\tbeendet das Programm\n\n");

                Console.WriteLine("Optionen:\n");
                Console.WriteLine("1. Die Schwerkraft eines Planeten berechnen (Rechnen)\n");
                Console.WriteLine("Wählen Sie eine Option aus.");

                string choice = Console.ReadLine();
                switch (choice)

                {
                    case "1":
                        Console.Write("\nGeben Sie den Namen des Planeten ein: ");
                        string planetName = Console.ReadLine();
                        if (planetName.ToLower() == "exit")
                        {
                            Environment.Exit(0);
                        }
                        else if (planetName.ToLower() == "submenu")
                        {
                            return;
                        }
                        else if (planetName == planetName)
                        {
                            Console.Write("\nGeben Sie die Masse des Planeten in kg ein: ");
                            string masse = Console.ReadLine();
                            if (masse.ToLower() == "exit")
                            {
                                Environment.Exit(0);
                            }
                            else if (masse.ToLower() == "subexit")
                            {
                                return;
                            }
                            else if (double.TryParse(masse, out double masse1))
                            {
                                Console.Write("\nGeben Sie den Radius des Planeten in Metern ein: ");
                                string radiusPlanet = Console.ReadLine();
                                if (radiusPlanet.ToLower() == "exit")
                                {
                                    Environment.Exit(0);
                                }
                                else if (radiusPlanet.ToLower() == "subexit")
                                {
                                    return;
                                }
                                else if (double.TryParse(radiusPlanet, out double radius1))
                                {
                                    double F = 6.67430e-11 * masse1 / (radius1 * radius1);
                                    Console.WriteLine($"Die Schwerkraft auf dem Planeten {planetName} beträgt {F}N.");
                                }
                                else
                                {
                                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein!");
                        }
                        break;

                    case "exit":
                        Exit = true;
                        break;

                    default:
                        Console.WriteLine("Ungültige Eingabe");
                        Console.ReadKey();

                        (int, int) cPosAM = Console.GetCursorPosition();

                        KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);

                        break;
                }
            } while (!Exit);
        }
    }
}