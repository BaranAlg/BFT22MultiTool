using Figgle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ITBFTKlassenBibliothek
{
    internal class Feature15
    {
        internal static void Feature_15()
        {
            // code
            double Byte;
            double Bit;
            bool Fehler;
            string Groeßen;

            Console.WriteLine(FiggleFonts.Slant.Render("Bits und Bytes"));
            Console.WriteLine("MenüPunkte:");
            Console.WriteLine("1. Bit nach Byte");
            Console.WriteLine("2. Größen rechner");
            Console.WriteLine("3. SubExit");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Wählen sie ein MenüPunkt aus");

            string auswahl = Console.ReadLine();
            if (auswahl == "1")
            {
                Console.WriteLine();
                Console.WriteLine("1.Bit nach Byte");
                Console.WriteLine("2.Byte nach Bit");
                auswahl = Console.ReadLine();
                if (auswahl == "1")
                {
                    // 1
                    Console.WriteLine("Geben sie Bit ein");
                    string sBit = Console.ReadLine();
                    Fehler = double.TryParse(sBit, out Bit);
                    Byte = Bit / 8;
                    Console.WriteLine($"Das ergebniss ist: {Byte}");
                    Console.ReadKey();
                }
                else if (auswahl == "2")
                {
                    // 2
                    Console.WriteLine("Geben sie Byte ein");
                    string sByte = Console.ReadLine();
                    Fehler = double.TryParse(sByte, out Byte);
                    Bit = Byte * 8;
                    Console.WriteLine($"Das ergebniss ist: {Bit}");
                    Console.ReadKey();

                }

            }
            else if (auswahl == "2")
            {
                Console.Clear();
                Console.WriteLine("Datenmengen-Einheiten Umrechner");



                // Eingabe der Datenmenge und Einheit
                Console.Write("Bitte geben Sie die Datenmenge ein: ");
                double Groese = double.Parse(Console.ReadLine());



                Console.Write("Bitte geben Sie die Einheit ein (TB, GB, MB, KB, B): ");
                string unit = Console.ReadLine();



                // Umrechnung der Eingabe in Bits
                double bits;
                double test3 = 1024;
                double test1 = 1000;
                switch (unit.ToUpper())
                {
                    case "TB":
                        bits = Groese * test1 * test1 * test1 * test1 * 8;
                        break;
                    case "GB":
                        bits = Groese * test1 * test1 * test1 * 8;
                        break;
                    case "MB":
                        bits = Groese * test1 * test1 * 8;
                        break;
                    case "KB":
                        bits = Groese * test1 * 8;
                        break;
                    case "B":
                        bits = Groese * 8;
                        break;
                    case "TiB":
                        bits = Groese * test3 * test3 * test3 * test3 * 8;
                        break;
                    case "GiB":
                        bits = Groese * test3 * test3 * test3 * 8;
                        break;
                    case "MiB":
                        bits = Groese * test3 * test3 * 8;
                        break;
                    case "KiB":
                        bits = Groese * test3 * 8;
                        break;
                    default:
                        Console.WriteLine("Ungültige Einheit.");
                        return;
                }


                Console.ReadKey();

                // Umrechnung in die gewünschte Einheit
                Console.Write("Möchten Sie die Datenmenge in eine bestimmte Einheit umrechnen? (Ja/Nein): ");
                string convertToUnit = Console.ReadLine();



                if (convertToUnit.ToLower() == "ja")
                {
                    Console.Write("Bitte geben Sie die gewünschte Einheit ein (TB, GB, MB, KB, B, TiB, GiB, MiB, KiB,): ");
                    string Einheit = Console.ReadLine();

                    double test2 = 1024;
                    double test = 1000;
                    double UmgerechneteGroesse;
                    switch (Einheit.ToUpper())
                    {
                        case "TB":
                            UmgerechneteGroesse = bits / (test * test * test * test * 8);
                            break;
                        case "GB":
                            UmgerechneteGroesse = bits / (test * test * test * 8);
                            break;
                        case "MB":
                            UmgerechneteGroesse = bits / (test * test * 8);
                            break;
                        case "KB":
                            UmgerechneteGroesse = bits / (test * 8);
                            break;
                        case "B":
                            UmgerechneteGroesse = bits / 8;
                            break;
                        case "TiB":
                            UmgerechneteGroesse = bits / (test2 * test2 * test2 * test2 * 8);
                            break;
                        case "GiB":
                            UmgerechneteGroesse = bits / (test2 * test2 * test2 * 8);
                            break;
                        case "MiB":
                            UmgerechneteGroesse = bits / (test2 * test2 * 8);
                            break;
                        case "KiB":
                            UmgerechneteGroesse = bits / (test2 * 8);
                            break;
                        default:
                            Console.WriteLine("Ungültige Einheit.");
                            return;
                    }



                    Console.WriteLine($"Die umgerechnete Datenmenge beträgt: {UmgerechneteGroesse} {Einheit}");
                }
                else
                {
                    Console.WriteLine($"Die Datenmenge in Bits beträgt: {bits} bit");
                }
                Console.WriteLine("Drücken sie eine taste um weiter zu gehen");
                Console.ReadLine();
                Console.Clear();
            }
            else if (auswahl == "3")
            {
                // Größem rechner
                Console.WriteLine("Programm wird beendet");
                Console.WriteLine("Geben sie eine taste ein");
                Console.ReadKey();
                ITBFTKlassenBibliothek.ITSubMenue.ITSubMenue1();
                Console.Clear();
            }
            else if (auswahl == "4")
            {
                Environment.Exit(0);
            }
            else
            {

            }
        }
    }
}
