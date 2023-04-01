using Figgle;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ITBFTKlassenBibliothek
{
    internal class Feature14
    {
        internal static void Feature_14()
        {
            string cpu_name = "";
            int cpu_pakete = 0;
            int wortbreite = 8;
            int phy_takt = 0;
            int bandbreite = 0;
            string bandbreite_STR;
            string[] auswahl = {"0", "0", "0", "0"};
            int auswahl_int = 0;
            bool convert;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("========================================================================");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(FiggleFonts.Slant.Render("RAM Rechner"));
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("========================================================================");
                Console.WriteLine(" ");
                Console.WriteLine("1. Prozessor Auswählen");
                Console.WriteLine(cpu_name);
                Console.WriteLine("2. Physikalische Taktrate");
                if (phy_takt > 1000)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bitte geben sie eie gültige takt frequizen an von 0-1000");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
                else
                {
                    Console.WriteLine($"{phy_takt} MHz");
                }
                Console.WriteLine("3. Rechnung Beginnen");
                auswahl[1] = Convert.ToString(Console.ReadLine());
                switch (auswahl[1])
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Bitte Wähle dein Prozessor aus.");
                        Console.WriteLine("1. AMD");
                        Console.WriteLine("2. Intel");
                        auswahl[2] = Convert.ToString(Console.ReadLine());
                        switch (auswahl[2])
                        {
                            case "1":
                                cpu_name = "AMD";
                                cpu_pakete = 2;
                                break;

                            case "2":
                                cpu_name = "Intel";
                                cpu_pakete = 4;
                                break;
                        }
                        break;
                    case "2":
                        PhyTakt();
                        break;
                    case "3":
                        if (phy_takt > 1000)
                        {
                            Feature14.Feature_14();
                        }
                        Console.Clear();
                        Console.WriteLine("=======================================");
                        Console.WriteLine("Mit Dieser Formel wird Gerechnet.");
                        Console.WriteLine("Bandbreite des Prozessors: Phy. Taktrate * Datenpakete * Wortbreite");
                        bandbreite = phy_takt * cpu_pakete * wortbreite;
                        Console.WriteLine($"Rechnung: {phy_takt} * {cpu_pakete} * {wortbreite}");
                        Console.WriteLine("=======================================");
                        bandbreite_STR = Convert.ToString(bandbreite);
                        ConsoleKeyInfo keyInfo;

                        do
                        {
                            Console.WriteLine("Drück Enter um das Ergebnis zu Sehen.");
                            keyInfo = Console.ReadKey();
                        } while (keyInfo.Key != ConsoleKey.Enter);

                        Console.Clear();
                        Console.WriteLine(FiggleFonts.Slant.Render("Ergebnis"));
                        Console.WriteLine(FiggleFonts.Slant.Render($"{bandbreite_STR} Mbyte/s"));
                        do
                        {
                            Console.WriteLine("Drück Enter um die Zweite Rechnung zu starten.");
                            keyInfo = Console.ReadKey();
                        } while (keyInfo.Key != ConsoleKey.Enter);

                        Console.Clear();
                        Console.WriteLine("Geben sie 1 für Singel ein und 2 für Dual.");
                        auswahl_int = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("=======================================");
                        Console.WriteLine("Mit Dieser Formel wird Gerechnet.");
                        Console.WriteLine("Passender RAM: Banbreite / Wortbreite");
                        int cur_wortbreite = 0;
                        cur_wortbreite = wortbreite * auswahl_int;
                        Console.WriteLine($"Rechnung: {bandbreite} Mbyte/s / {cur_wortbreite} Byte");
                        Console.WriteLine("=======================================");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
                static void PhyTakt()
                {
                    Console.Clear();
                    Console.WriteLine("Bitte Geben sie die Physikalische Taktrate ihres Prozessors an.");
                    phy_takt = Convert.ToInt32(Console.ReadLine());
                }

            } while (true);
        }
    }
}
