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

                double G = 6.67430e-11; // Gravitationskonstante
                double m, r;
                string planetName;
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
                        planetName = Console.ReadLine();
                        Console.Write("\nGeben Sie die Masse des Planeten in kg ein: ");
                        m = double.Parse(Console.ReadLine());
                        Console.Write("\nGeben Sie den Radius des Planeten in Metern ein: ");
                        r = double.Parse(Console.ReadLine());

                        double F = G * m / (r * r);
                        break;

                    case "exit":
                        Exit = true;
                        break;

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
