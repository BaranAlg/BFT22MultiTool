using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHFragBFTKlassenBibliothek
{
    internal class Feature8
    {
        internal static void feature_8()
        {
           bool Exit = false;
            
           do
           {
                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "|                 >>> Infos zur Aufbau und Strucktur der Materie <<<               |\n" +
                                  "------------------------------------------------------------------------------------\n");

                Console.WriteLine("Eingabe: exit\t->\tbeendet das Programm");

                Console.WriteLine("1. Atomphysik");
                Console.WriteLine("2. Kernphysik");
                Console.WriteLine("3. Relativitätstheorie");
                Console.WriteLine("4. Astrophysik");
                Console.Write("Wählen Sie bitte ein Punkt aus: ");
                string menu = Console.ReadLine();

                switch(menu)
                {
                    case "1":
                        Console.WriteLine("Test");
                        break;
                    case "2":
                        Console.WriteLine("Test");
                        break;
                    case "3":
                        Console.WriteLine("Test");
                        break;
                    case "4":
                        Console.WriteLine("Test");
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
                        Console.ReadKey();
                }
           } while (!Exit);
        }
    }
}
