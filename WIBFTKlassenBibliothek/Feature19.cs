using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIBFTKlassenBibliothek
{
    internal class Feature19
    {
        internal static void Feature_19()
        {
                bool exit = false;

                while (!exit)
                {
                    Console.WriteLine("Bitte geben Sie Ihre Steuerklasse (1-6) ein:");
                    string input = Console.ReadLine();
                    int steuerklasse;



                    if (int.TryParse(input, out steuerklasse))
                    {
                        if (steuerklasse >= 1 && steuerklasse <= 6)
                        {
                            double brutto = 0;
                            double netto = 0;



                            Console.WriteLine("Bitte geben Sie Ihr Bruttogehalt ein:");
                            input = Console.ReadLine();



                            if (double.TryParse(input, out brutto))
                            {
                                switch (steuerklasse)
                                {
                                    case 1:
                                        netto = brutto * 0.88;
                                        break;
                                    case 2:
                                        netto = brutto * 0.84;
                                        break;
                                    case 3:
                                        netto = brutto * 0.78;
                                        break;
                                    case 4:
                                        netto = brutto * 0.74;
                                        break;
                                    case 5:
                                        netto = brutto * 0.66;
                                        break;
                                    case 6:
                                        netto = brutto * 0.60;
                                        break;
                                }



                                Console.WriteLine("Ihr Nettogehalt beträgt: {0}", netto);
                            }
                            else
                            {
                                Console.WriteLine("Fehler: Ungültige Eingabe für das Bruttogehalt.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Fehler: Die Steuerklasse muss zwischen 1 und 6 liegen.");
                        }
                    }
                    else if (input.ToLower() == "exit")
                    {
                        exit = true;
                    }
                    else if (input.ToLower() != "subexit")
                    {
                        Console.WriteLine("Fehler: Ungültige Eingabe für die Steuerklasse.");
                    }



                    if (!exit)
                    {
                        Console.WriteLine("Drücken Sie eine beliebige Taste, um fortzufahren oder 'exit' einzugeben, um das Programm zu beenden.");
                        input = Console.ReadLine();
                        if (input.ToLower() == "exit")
                        {
                            exit = true;
                        }
                    }
                }
            }
        }
    }

