using Figgle;



namespace ITBFTKlassenBibliothek
{
    public class ITSubMenue
    {
        public static void ITSubMenue1()
        {
            bool Exit = false;

            do
            {

                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();

                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFTMultiTool"));

                //Konsolentitel wird geändert.
                Console.Title = "BFTMultiTool";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> ItMenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t->\tbeendet das Programm");

                //Beschreibung der Software.
                Console.WriteLine("\n\nMit der Software 'BFTMulti-Tool' sollen wiederkehrende oder besonders aufwendige\n" +
                                  "Aufgabenaus dem schulischen Kontext erleichtert oder gelöst werden. Diese Aufgaben\n" +
                                  "ergeben sich aus den Problemstellungen aus dem Unterricht der Berufsfachschule für Technik.\n\n");

                string HauptAusw;


                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\tb - Bits und Bytes umrechner");
                Console.WriteLine("\tv - Video/Bild/Audio berechner");
                Console.WriteLine("\tt - Task-Manager");
                Console.WriteLine("\tp - Passender Arbeitsspeicher rechner");
                Console.WriteLine("\td - Datei Pfad ausgeben\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine().ToLower();

                switch (HauptAusw)
                {
                    case "b":
                        Console.Clear();
                        Feature15.Feature_15();
                        break;

                    case "v":
                        Console.Clear();
                        Feature12.Feature_12();
                        break;

                    case "t":
                        Console.Clear();
                        Feature11.TaskManager();
                        break;

                    case "p":
                        Console.Clear();
                        Feature14.Feature_14();
                        break;

                    case "d":
                        Console.Clear();
                        Feature13.Feature_13();
                        break;

                    case "exit":
                        Exit = true;
                        Console.Clear();
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