using Figgle;
using System.Diagnostics;


namespace ITBFTKlassenBibliothek
{
    internal class Feature11
    {
        internal static void TaskManager()
        {
            bool Schleife = true;
            bool Crash;
            string sAuswahl;
            int iAuswahl;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine(FiggleFonts.Slant.Render("Task-Manager"));
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Menüpunkte:");
                Console.WriteLine("1. PC Prozesse");
                Console.WriteLine("2. Alle HintergrundProzesse");
                Console.WriteLine("3. Computer hardware ausgeben");
                Console.WriteLine("4. PC Auslastung");
                Console.WriteLine("5. Submenü verlassen");
                Console.WriteLine("6. Exit");
                sAuswahl = Console.ReadLine();
                Crash = int.TryParse(sAuswahl, out iAuswahl);
                if(Crash == false)
                {
                    Feature11.TaskManager();
                }
                switch (iAuswahl)
                {
                    case 1:
                        PC_Prozesse();
                        break;
                    case 2:
                        Alle_HinterGrundProzesse();
                        break;
                    case 3:
                        Computer_Hardware_Ausgebene();
                        break;
                    case 4:
                        PC_Auslastung();
                        break;
                    case 5:
                        Schleife = false;
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                }

                static void PC_Prozesse()
                {
                    // PC_Prozesse
                }
                static void Alle_HinterGrundProzesse()
                {
                    // Alle_HinterGrundProzesse
                }
                static void Computer_Hardware_Ausgebene()
                {
                    // Alle_HinterGrundProzesse
                }
                static void PC_Auslastung()
                {
                    // PC_Auslastung
                }
                Console.ReadKey();
            } while (Schleife == true);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
        }
    }
}
