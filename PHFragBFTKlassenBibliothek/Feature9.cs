using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHFragBFTKlassenBibliothek
{
    internal class Feature9
    {
        internal static void feature_9()
        {
            bool Exit = false;
            do
            {
                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "|                          >>> Berechnung von Volumen <<<                           |\n" +
                                  "------------------------------------------------------------------------------------\n");
                Console.WriteLine("Optionen für die Volumen Berechnung");
                Console.WriteLine("1. Würfel");
                Console.WriteLine("2. Kugel");
                Console.WriteLine("3. Pyramide");
                Console.WriteLine("4. Prisma");
                Console.Write("\nBitte geben sie eine Option ein: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("\nBitte geben sie die Kantenlänge des Würfels ein: ");
                        double length = double.Parse(Console.ReadLine());
                        double volume = Math.Pow(length, 3);
                        Console.WriteLine($"\nDas Volumen des Würfels beträgt: {volume}qm");
                        break;

                    case "2":
                        Console.Write("\nBitte geben sie den Radius der Kugel ein: ");
                        double radius = double.Parse(Console.ReadLine());
                        volume = 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);
                        Console.WriteLine($"\nDas Volumen der Kugel beträgt: {volume}qm");
                        break;

                    case "3":
                        Console.Write("\nBitte geben Sie die Grundfläche der Pyramide ein: ");
                        double baseLength = double.Parse(Console.ReadLine());
                        Console.Write("\nBitte geben Sie die Höhe der Pyramide ein: ");
                        double height = double.Parse(Console.ReadLine());
                        volume = 1.0 / 3.0 * baseLength * baseLength * height;
                        Console.WriteLine($"\nDas Volumen der Pyramide beträgt: {volume}qm");
                        break;

                    case "4":
                        Console.Write("\nBitte geben Sie die Grundfläche des Prismas ein: ");
                        baseLength = double.Parse(Console.ReadLine());
                        Console.Write("\nBitte geben Sie die Breite des Prismas ein: ");
                        double width = double.Parse(Console.ReadLine());
                        Console.Write("\nBitte geben Sie die Höhe des Prismas ein: ");
                        height = double.Parse(Console.ReadLine());
                        volume = baseLength * width * height;
                        Console.WriteLine($"\nDas Volumen des Prismas beträgt: {volume}qm");
                        break;

                    case "exit":
                        Exit = true;
                        break;

                    default:
                        Console.WriteLine("\nUngültige Auswahl. Bitte wählen Sie eine gültige Option.");

                        (int, int) cPosAM = Console.GetCursorPosition();

                        KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);
                        break;
                        Console.ReadKey();
                }
            } while (!Exit);
        }
    }
}