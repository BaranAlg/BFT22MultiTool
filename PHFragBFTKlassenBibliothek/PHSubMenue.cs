using Figgle;

namespace PHFragBFTKlassenBibliothek
{
    public class PHMenue
    {

        public static void PHSubmenu()
        {
            bool Exit = false;

            do
            {

                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                //ASCII art Logo wird erzeugt.
                Console.WriteLine(FiggleFonts.Slant.Render("BFTMultiTool"));

                //Konsolentitel wird geändert.
                Console.Title = "BFTMultiTool";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "|                              >>> Physik Submenu <<<                              |\n" +
                                  "------------------------------------------------------------------------------------\n");

                Console.WriteLine("Eingabe: exit\t->\tbeendet das Programm");

                //Beschreibung der Software.
                Console.WriteLine("\n\nMit der Software 'BFTMulti-Tool' sollen wiederkehrende oder besonders aufwendige\n" +
                                  "Aufgabenaus dem schulischen Kontext erleichtert oder gelöst werden. Diese Aufgaben\n" +
                                  "ergeben sich aus den Problemstellungen aus dem Unterricht der Berufsfachschule für Technik.\n\n");

                string HauptAusw;


                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Physik Unterthemen aus:\n");
                Console.WriteLine("1. Konverter");
                Console.WriteLine("2. Schwerkraft-Rechner");
                Console.WriteLine("3. Aufbau und Strucktur der Materie");
                Console.WriteLine("4. Berechnung von Volumen");
                Console.Write("\nEingabe: ");
                HauptAusw = Console.ReadLine().ToLower();

                switch (HauptAusw)
                {
                    case "1":
                        Console.Clear();
                        Feature6.feature_6();
                        break;

                    case "2":
                        Console.Clear();
                        Feature7.feature_7();
                        break;

                    case "3":
                        Console.Clear();
                        Feature8.feature_8();
                        break;

                    case "4":
                        Console.Clear();
                        Feature9.feature_9();
                        break;
                    case "exit":
                        Exit = true;
                        break;
                    default:

                        Console.WriteLine("Ungültige Eingabe");

                        (int, int) cPosAM = Console.GetCursorPosition();

                        KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);
                        break;
                        Console.ReadKey();
                }

            } while (!Exit);


        }
    }
}