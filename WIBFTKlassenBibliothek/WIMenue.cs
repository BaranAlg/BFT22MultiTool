
using Figgle;

namespace WIBFTKlassenBibliothek
{
    public class WIMenue
    {
        public static void WISubmenü()
        {
            bool Exit = false;

            do
            {

                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();

                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("WirtDoppelt"));

                //Konsolentitel wird geändert.
                Console.Title = "WirtDoppelt";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> WISubmenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t->\tbeendet das Programm");

                //Beschreibung der Software.
                Console.WriteLine("\n\nMit der Software 'BFTMulti-Tool' sollen wiederkehrende oder besonders aufwendige\n" +
                                  "Aufgabenaus dem schulischen Kontext erleichtert oder gelöst werden. Diese Aufgaben\n" +
                                  "ergeben sich aus den Problemstellungen aus dem Unterricht der Berufsfachschule für Technik.\n\n");

                string HauptAusw;


                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\te - Handyvertrag");
                Console.WriteLine("\ti - Autoversicherung");
                Console.WriteLine("\tm - Immobilienrechner");
                Console.WriteLine("\tp - Gehaltsrechner");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine().ToLower();

                switch (HauptAusw)
                {
                    case "e":
                        Console.Clear();
                        Feature16.Feature_16();
                        break;

                    case "i":
                        Console.Clear();
                        Feature17.Feature_17();
                        break;

                    case "m":
                        Console.Clear();
                        Feature18.Feature_18();
                        break;

                    case "p":
                        Console.Clear();
                        Feature19.Feature_19();
                        break;

                    case "w":
                        Console.Clear();
                        //Hier das Wirtschaftsmenü aufrufen
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
