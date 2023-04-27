using System;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using Figgle;
using System.IO;
using System.Diagnostics;


namespace WIBFTKlassenBibliothek
{
    internal class Feature17
    {
        #region main
        internal static void Feature_17()
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            string textToAnimate = (FiggleFonts.Slant.Render("Wilkommen bei der Autoversicherung App "));
            foreach (char c in textToAnimate)
            {
                if (c == '\n')
                {
                    Thread.Sleep(500);
                }
                Console.Write(c);
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string textToAnimate8 = "Bitte Wählen sie ein Menü Punkt Aus";
            foreach (char c in textToAnimate8)
            {
                Console.Write(c);
                Thread.Sleep(1);
            }
            Console.WriteLine();
            Console.Clear();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                string textToAnimate6 = (FiggleFonts.Slant.Render("Wilkommen bei der Autoversicherung App "));
                foreach (char c in textToAnimate6)
                {
                    if (c == '\n')
                    {
                        Thread.Sleep(1);
                    }
                    Console.Write(c);
                }
                Console.WriteLine("-------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string textToAnimate9 = "Bitte Wählen sie ein Menü Punkt Aus";
                foreach (char c in textToAnimate9)
                {
                    Console.Write(c);
                    Thread.Sleep(1);
                }
                Console.WriteLine();
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1. Neue Versicherung berechnen");
                Console.WriteLine("2. Hilfe?:");
                Console.WriteLine("3. Programm beenden");
                Console.Write("Option: ");
                int option;
                while (!int.TryParse(Console.ReadLine(), out option) || (option < 1 || option > 3))
                {
                    Console.Clear();
                    //Nach der anzeige für eine fehlermeldung der code
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    string textToAnimate7 = (FiggleFonts.Slant.Render("Ungültig"));
                    foreach (char c in textToAnimate)
                    {
                        if (c == '\n')
                        {
                            Thread.Sleep(1);
                        }
                        Console.Write(c);
                    }
                    Console.WriteLine("-------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    string textToAnimate70 = "Bitte Wählen sie ein Menü Punkt Aus";
                    foreach (char c in textToAnimate8)
                    {
                        Console.Write(c);
                        Thread.Sleep(1);
                    }
                    Console.WriteLine();
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("1. Neue Versicherung berechnen");
                    Console.WriteLine("2. Hilfe?:");
                    Console.WriteLine("3. Programm beenden"); Console.Write("Option: ");
                    Console.WriteLine();
                    Console.WriteLine();
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        string txt = "Bitte geben Sie eine gültige Option ein.";
                        int durationInSeconds = 4;
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        while (stopwatch.Elapsed < TimeSpan.FromSeconds(durationInSeconds))
                        {
                            WriteBlinkingText(txt, 500, true);
                            WriteBlinkingText(txt, 500, false);
                        }
                        stopwatch.Stop();
                    }
                    static void WriteBlinkingText(string text, int delay, bool visible)
                    {
                        if (visible)
                            Console.Write(text);
                        else for (int i = 0; i < text.Length; i++)
                                Console.Write(" ");
                        Console.CursorLeft -= text.Length;
                        System.Threading.Thread.Sleep(delay);
                    }
                }
                switch (option)
                {
                    case 1:
                        GetUserInformation();
                        break;
                    case 2:
                        ShowInsuranceInformation();
                        break;
                    case 3:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        string textToAnimate7 = (FiggleFonts.Slant.Render("Auf Wiedersehen ! "));
                        foreach (char c in textToAnimate7)
                        {
                            if (c == '\n')
                            {
                                Thread.Sleep(300);
                            }
                            Console.Write(c);
                        }
                        Console.WriteLine("------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        string textToAnimate4 = "Danke das sie unseren versicherungsrechner benutzt haben !!!";
                        foreach (char c in textToAnimate4)
                        {
                            Console.Write(c);
                            Thread.Sleep(50);
                        }
                        Console.ReadKey();
                        return;
                }
            }

            #endregion



            static void GetUserInformation()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string textToAnimate = (FiggleFonts.Slant.Render("Hauptmenü"));
                foreach (char c in textToAnimate)
                {
                    if (c == '\n')
                    {
                        Thread.Sleep(270);
                    }
                    Console.Write(c);
                }
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Bitte geben Sie Ihre persönlichen Informationen ein:");
                string name = "";
                while (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine(""); Console.WriteLine("Namen:");
                    name = Console.ReadLine();
                    if (string.IsNullOrEmpty(name))
                    {
                        string textToAnimate5 = "Bitte geben sie einen gültigen Namen ein";
                        foreach (char c in textToAnimate5)
                        {
                            Console.Write(c);
                            Thread.Sleep(20);
                        }
                    }
                }
                Console.Write("Alter: ");
                int age;
                while (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Bitte geben Sie eine gültige Zahl ein.");
                    Console.Write("Alter: ");
                }
                Console.Write("Auto Marke: ");
                string carBrand = Console.ReadLine(); Console.Write("Auto Modell: ");
                string carModel = Console.ReadLine(); Console.Write("Klasse (Standard, Mittelklasse, Oberklasse): ");
                string carClass = Console.ReadLine(); Console.Write("Jährliche Kilometerleistung: ");
                int annualMileage;
                while (!int.TryParse(Console.ReadLine(), out annualMileage))
                {
                    Console.WriteLine("Bitte geben Sie eine gültige Zahl ein.");
                    Console.Write("Jährliche Kilometerleistung: ");
                }
                Console.WriteLine("Berechne Prämie...");
                double premium = CalculatePremium(age, carBrand, carClass, annualMileage);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(
                FiggleFonts.Standard.Render("Vielen Dank !!"));
                Console.WriteLine("------------------------------------------");
                string textToAnimate7 = "Ihre jährliche Prämie beträgt: $" + premium;
                foreach (char c in textToAnimate7)
                {
                    Console.Write(c);
                    Thread.Sleep(20);
                }
                Console.WriteLine();
                string input;
                {
                    Console.WriteLine();
                    string textToAnimate5 = "Zum Fortfahren 2x Enter Drücken";
                    foreach (char c in textToAnimate5)
                    {
                        Console.Write(c);
                        Thread.Sleep(20);
                    }
                    input = Console.ReadLine();
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            static void ShowInsuranceInformation()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                string textToAnimate = (FiggleFonts.Slant.Render("Hilfemenü"));
                foreach (char c in textToAnimate)
                {
                    if (c == '\n')
                    {
                        Thread.Sleep(270);
                    }
                    Console.Write(c);
                }
                Console.WriteLine("------------------------------------------");
                int choice;
                {
                    {
                        Console.WriteLine("1. Hilfe");
                        Console.WriteLine("2. Zurück");
                        Console.Write("Ihre Wahl: ");
                        string input = Console.ReadLine();
                        int.TryParse(input, out choice);
                        switch (choice)
                        {
                            case 1:
                                GetUserInformation2();
                                Console.WriteLine("");
                                Console.ReadLine();
                                Console.ReadKey();
                                return;
                            case 2:
                                Console.WriteLine("Zum Fortfahren 2x Enter Drücken ");
                                Console.ReadLine();
                                Console.ReadKey();
                                Console.Clear();
                                return;
                            default:
                                {
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        string txt = "Bitte geben Sie eine gültige Option ein.";
                                        int durationInSeconds = 4;
                                        Stopwatch stopwatch = new Stopwatch();
                                        stopwatch.Start();
                                        while (stopwatch.Elapsed < TimeSpan.FromSeconds(durationInSeconds))
                                        {
                                            WriteBlinkingText(txt, 500, true);
                                            WriteBlinkingText(txt, 500, false);
                                        }
                                        stopwatch.Stop();
                                    }
                                    static void WriteBlinkingText(string text, int delay, bool visible)
                                    {
                                        if (visible)
                                            Console.Write(text);
                                        else for (int i = 0; i < text.Length; i++)
                                                Console.Write(" ");
                                        Console.CursorLeft -= text.Length;
                                        System.Threading.Thread.Sleep(delay);
                                    }
                                    Console.ReadKey();
                                    break;
                                } while (choice != 3) ;
                        }
                    } while (choice != default) ;
                }
            }

        }
        static double CalculatePremium(int age, string carBrand, string carClass, int annualMileage)
        {
            double basePremium = 500;
            if (age < 18 || age == 18)
            {
                basePremium *= 0.8;
            }
            else if (age > 18 && age < 120)
            {
                basePremium *= 1.2;
            }
            else
            {
                Console.WriteLine("Fehler zu Alt");
                Console.ReadKey();
            }
            if (carBrand.Equals("BMW", StringComparison.InvariantCultureIgnoreCase) || carBrand.Equals("Mercedes-Benz", StringComparison.InvariantCultureIgnoreCase) || carBrand.Equals("Audi", StringComparison.InvariantCultureIgnoreCase))
            {
                basePremium *= 1.2;
            }
            if (carClass.Equals("Mittelklasse", StringComparison.InvariantCultureIgnoreCase))
            {
                basePremium *= 1.1;
            }
            else if (carClass.Equals("Oberklasse", StringComparison.InvariantCultureIgnoreCase))
            {
                basePremium *= 1.3;
            }
            basePremium += (annualMileage * 0.1); return basePremium;
        }
        static void GetUserInformation2()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string textToAnimate5 = "Herzlich willkommen zum Hilfe-Menü für die Angabe Ihrer Autoversicherungsdaten. Bitte stellen Sie sicher, dass Sie die folgenden Informationen zur Hand haben:" + "\r\n\r\nName: Geben Sie Ihren vollständigen Namen ein, wie er in Ihrem Ausweis oder Führerschein erscheint." + "\r\n\r\nAlter: Geben Sie Ihr Alter zum Zeitpunkt der Antragstellung an." + "\r\n\r\nAuto: Geben Sie das Herstellungsjahr, Marke und Modell Ihres Autos an." + "\r\n\r\nAutoklasse: Wählen Sie die passende Autoklasse für Ihr Auto aus. Dies wird normalerweise anhand der Größe und Leistung Ihres Autos bestimmt." + "\r\n\r\nJährliche Kilometerleistung: Geben Sie die jährliche Kilometerleistung Ihres Autos an. Dies ist wichtig, da es sich auf Ihre Versicherungsprämie auswirken kann." + "\r\n\r\nBitte stellen Sie sicher, dass alle Angaben korrekt sind, um sicherzustellen, dass Ihre Versicherungspolice korrekt und auf Ihre Bedürfnisse zugeschnitten ist." + " Wenn Sie Fragen haben oder weitere Hilfe benötigen, zögern Sie bitte nicht, und kontaktieren Herr Akinci. " + "" + "Vielen Dank für Ihre Zusammenarbeit!";
            foreach (char c in textToAnimate5)
            {
                Console.Write(c);
                Thread.Sleep(20);
            }
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Zum fortfahren beliebige taste drücken");
            Console.ReadKey();
            Console.Clear();
            return;
        }
    }
}
