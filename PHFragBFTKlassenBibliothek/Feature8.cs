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
                        Console.WriteLine("\nAtomphysik. Die Atomphysik untersucht den Aufbau der Atome aus Atomkern und \nElektronenhülle und die Wechselwirkungen der Atome und Ionen mit anderen Atomen oder Ionen, mit Festkörpern, mit elektromagnetischer Strahlung und Teilchenstrahlung, mit elektrischen und magnetischen Feldern. Meist wird der Begriff auf die Untersuchung von Struktur ");
                        break;
                    case "2":
                        Console.WriteLine("Die Kernphysik ist ein Teilbereich der Physik, der sich mit dem Aufbau und dem Verhalten von Atomkernen \nbeschäftigt. Während die Atomphysik sich mit der Physik der Atomhülle befasst, ist Gegenstand der Kernphysik die Aufklärung der Kernstruktur, also der Einzelheiten des Aufbaus der Atomkerne. Hierzu werden beispielsweise spontane Umwandlungen der Atomkerne untersucht");
                        break;
                    case "3":
                        Console.WriteLine("Die Relativitätstheorie ist eine Theorie der Physik, die sich mit der Struktur von Raum und Zeit sowie mit \ndem Wesen der Gravitation befasst. Sie besteht aus zwei maßgeblich von Albert Einstein entwickelten physikalischen Theorien: der 1905 veröffentlichten speziellen Relativitätstheorie und der 1916 abgeschlossenen allgemeinen Relativitätstheorie1");
                        break;
                    case "4":
                        Console.WriteLine("Die Astrophysik ist ein Teilgebiet der Astronomie, das sich mit der Untersuchung der physikalischen Beschaffenheit \nder kosmischen Objekte befasst. Sie nimmt gegenwärtig den breitesten Raum innerhalb der Astronomie ein1.\r\n\r\n");
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
