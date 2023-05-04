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
            string[] auswahl = { "0", "0", "0", "0", "0" };
            string RAM = "";
            string namenserweiterung_STR = "";
            int namenserweiterung = 0;
            int modus = 0;
            bool convert;
            bool loop = true;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("========================================================================");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(FiggleFonts.Slant.Render("RAM Rechner"));
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(" ");
                Console.WriteLine(" Exit = Beendet das Programm");
                Console.WriteLine(" Subexit = Zurück ins IT-Menü");
                Console.WriteLine("========================================================================");
                Console.WriteLine(" ");
                Console.WriteLine("1. Prozessor Auswählen");
                Console.WriteLine(cpu_name);
                Console.WriteLine("2. Physikalische Taktrate");
                if (phy_takt > 1000)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bitte geben sie eie gültige takt Frequenz an von 0-1000");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
                else
                {
                    Console.WriteLine($"{phy_takt} MHz");
                }
                if (phy_takt > 1000)
                {
                    Console.WriteLine("3. Rechnung Beginnen");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Rechnung kann nicht gestartet werden, Bitte geben sie zuerst eine Gültige Taktfrequenz an.");
                }
                else
                {
                    Console.WriteLine("3. Rechnung Beginnen");
                }
                auswahl[1] = Convert.ToString(Console.ReadLine());
                if (auswahl[1] == "exit")
                {
                    auswahl[1] = "Exit";
                }
                else if (auswahl[1] == "subexit")
                {
                    auswahl[1] = "Subexit";
                }
                switch (auswahl[1])
                {
                    case "1":
                        Prozessor();
                        break;
                    case "2":
                        PhyTakt();
                        break;
                    case "3":
                        if (phy_takt > 1000)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("3. Rechnung Beginnen \nRechnung kann nicht gestartet werden, Bitte geben sie zuerst eine Gültige Taktfrequenz an.");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.ReadKey();
                        }
                        else
                        {
                            Rechnung();
                        }
                        break;
                    case "Subexit":
                        loop = false;
                        break;
                    case "Exit":
                        Environment.Exit(0);
                        break;
                    default:
                        Default();
                        break;
                }
                Console.Clear();

                void Prozessor()
                {
                    Console.Clear();
                    Console.WriteLine("===============================");
                    Console.WriteLine("Bitte Wähle dein Prozessor aus.");
                    Console.WriteLine("===============================");
                    Console.WriteLine("1. AMD");
                    Console.WriteLine("2. Intel");
                    auswahl[2] = Convert.ToString(Console.ReadLine());
                    if (auswahl[2] == "exit")
                    {
                        auswahl[2] = "Exit";
                    }
                    else if (auswahl[2] == "subexit")
                    {
                        auswahl[2] = "Subexit";
                    }
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
                        case "Subexit":
                            Feature_14();
                            break;
                        case "Exit":
                            Environment.Exit(0);
                            break;
                        default:
                            Default2();
                            break;
                    }
                }

                void PhyTakt()
                {
                    Console.Clear();
                    Console.WriteLine("===================================================");
                    Console.WriteLine("Bitte gib eine Physikalische Takrate von 1-1000 an.");
                    Console.WriteLine("===================================================");
                    Console.WriteLine(" ");

                    while (true)
                    {
                        auswahl[3] = Console.ReadLine();

                        if (auswahl[3].ToLower() == "exit")
                        {
                            Environment.Exit(0);
                        }
                        else if (auswahl[3].ToLower() == "subexit")
                        {
                            Feature_14();
                            return;
                        }
                        else if (int.TryParse(auswahl[3], out int phyTaktInput))
                        {
                            if (phyTaktInput < 1 || phyTaktInput > 1000)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Bitte geben sie eine gültige Taktfrequenz an von 1-1000 MHz.");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                            }
                            else
                            {
                                phy_takt = phyTaktInput;
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Falsche Eingabe \nBitte geben sie eine Zahl ein.");
                        }
                    }
                }

                void Rechnung()
                {
                    if (phy_takt > 1000)
                    {
                        Feature_14();
                    }
                    Console.Clear();
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Mit Dieser Formel wird Gerechnet.");
                    Console.WriteLine("Bandbreite des Prozessors: Phy. Taktrate * Datenpakete * Wortbreite");
                    bandbreite = phy_takt * cpu_pakete * wortbreite;
                    Console.WriteLine($"Rechnung: {phy_takt} * {cpu_pakete} * {wortbreite}");
                    Console.WriteLine("=======================================");
                    bandbreite_STR = Convert.ToString(bandbreite);
                    if (bandbreite <= 1000)
                    {
                        RAM = "SDRAM";
                    } 
                    else if (bandbreite <= 2100)
                    {
                        RAM = "DDR1";
                    } 
                    else if (bandbreite <= 8500)
                    {
                        RAM = "DDR2";
                    } 
                    else if (bandbreite <= 17000)
                    {
                        RAM = "DDR3";
                    }
                    else if (bandbreite <= 34000)
                    {
                        RAM = "DDR4";
                    }
                    else if (bandbreite <= 76800)
                    {
                        RAM = "DDR5";
                    }
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
                    Rechnung2();

                    
                }

                void Rechnung2()
                {
                    Console.Clear();
                    Console.WriteLine("Geben sie 1 für Singel ein und 2 für Dual Modus.");
                    auswahl[4] = Convert.ToString(Console.ReadLine());
                    if (auswahl[4] == "exit")
                    {
                        auswahl[4] = "Exit";
                    }
                    else if (auswahl[4] == "subexit")
                    {
                        auswahl[4] = "Subexit";
                    }
                    switch (auswahl[4])
                    {
                        case "1":
                            modus = 1;
                            break;
                        case "2":
                            modus = 2;
                            break;
                        case "Subexit":
                            Feature_14();
                            break;
                        case "Exit":
                            Environment.Exit(0);
                            break;
                        default:
                            Default3();
                            break;
                    }
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Mit Dieser Formel wird Gerechnet.");
                    Console.WriteLine("Passender RAM: Banbreite / Wortbreite");
                    int cur_wortbreite = 0;
                    cur_wortbreite = wortbreite * modus;
                    namenserweiterung = bandbreite / cur_wortbreite;
                    Console.WriteLine($"Rechnung: {bandbreite} Mbyte/s / {cur_wortbreite} Byte");
                    Console.WriteLine("=======================================");
                    namenserweiterung_STR = Convert.ToString(namenserweiterung);
                    ConsoleKeyInfo keyInfo;

                    do
                    {
                        Console.WriteLine("Drück Enter um das Ergebnis zu Sehen.");
                        keyInfo = Console.ReadKey();
                    } while (keyInfo.Key != ConsoleKey.Enter);

                    Console.Clear();
                    Console.WriteLine(FiggleFonts.Slant.Render("Ergebnis"));
                    Console.WriteLine(FiggleFonts.Slant.Render($"{namenserweiterung_STR}"));

                    do
                    {
                        Console.WriteLine("Drücken sie Enter um Weiter zu Gehen.");
                        keyInfo = Console.ReadKey();
                    } while (keyInfo.Key != ConsoleKey.Enter);
                    Ergebnis();
                }

                void Ergebnis()
                {
                    Console.Clear();
                    Console.WriteLine(FiggleFonts.Slant.Render("Passender RAM"));
                    Console.WriteLine(FiggleFonts.Slant.Render($"{RAM}--{namenserweiterung_STR}"));

                    Console.ReadKey();
                    Feature_14();
                }

                void Default()
                {
                    ConsoleKeyInfo keyInfo;
                    Console.Clear();
                    Console.WriteLine("Falsche Eingabe");
                    do
                    {
                        Console.WriteLine("Drücken sie Enter um die Eingabe erneut Einzugeben.");
                        keyInfo = Console.ReadKey();
                    } while (keyInfo.Key != ConsoleKey.Enter);
                }
                void Default2()
                {
                    ConsoleKeyInfo keyInfo;
                    Console.Clear();
                    Console.WriteLine("Falsche Eingabe");
                    do
                    {
                        Console.WriteLine("Drücken sie Enter um die Eingabe erneut Einzugeben.");
                        keyInfo = Console.ReadKey();
                    } while (keyInfo.Key != ConsoleKey.Enter);
                    Prozessor();
                }

                void Default3()
                {
                    ConsoleKeyInfo keyInfo;
                    Console.Clear();
                    Console.WriteLine("Falsche Eingabe");
                    do
                    {
                        Console.WriteLine("Drücken sie Enter um die Eingabe erneut Einzugeben.");
                        keyInfo = Console.ReadKey();
                    } while (keyInfo.Key != ConsoleKey.Enter);
                    Rechnung2();
                }
            } while (loop == true);
        }
    }
}
