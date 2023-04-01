using Figgle;
using System.Diagnostics;
using System.Management;

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
                    Console.Clear();
                    Process[] processes = Process.GetProcesses();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(FiggleFonts.Slant.Render("Laufende-Programme"));
                    Console.ForegroundColor = ConsoleColor.Green;
                    for (int i = 0; i < processes.Length; i++)
                    {
                        if (!string.IsNullOrEmpty(processes[i].MainWindowTitle))
                        {
                            Console.WriteLine($"{i + 1}. {processes[i].MainWindowTitle}");
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Drücken Sie eine beliebige Taste zum Fortfahren.");
                    Console.ReadLine();
                    Console.Clear();
                }
                static void Alle_HinterGrundProzesse()
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(FiggleFonts.Slant.Render("Laufende Prozesse:"));
                    Process[] processes = Process.GetProcesses();
                    Console.ForegroundColor = ConsoleColor.Green;

                    foreach (Process process in processes)
                    {
                        Console.WriteLine(process.ProcessName);
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Drücken Sie eine beliebige Taste zum Fortfahren.");
                    Console.ReadLine();
                    Console.Clear();
                }
                static void Computer_Hardware_Ausgebene()
                {
                    Console.WriteLine("PC-Hardwareinformationen:");
                    Console.WriteLine("-------------------------");

                    ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_Processor");
                    foreach (ManagementObject mo in searcher.Get())
                    {
                        Console.WriteLine("CPU: {0}", mo["Name"]);
                    }

                    searcher = new ManagementObjectSearcher("select * from Win32_ComputerSystem");
                    foreach (ManagementObject mo in searcher.Get())
                    {
                        Console.WriteLine("RAM: {0} GB", Math.Round(Convert.ToDouble(mo["TotalPhysicalMemory"]) / (1024 * 1024 * 1024), 2));
                    }

                    searcher = new ManagementObjectSearcher("select * from Win32_VideoController");
                    foreach (ManagementObject mo in searcher.Get())
                    {
                        Console.WriteLine("GPU: {0}", mo["Name"]);
                    }

                    searcher = new ManagementObjectSearcher("select * from Win32_NetworkAdapter where NetConnectionStatus = 2");
                    foreach (ManagementObject mo in searcher.Get())
                    {
                        Console.WriteLine("Network Adapter: {0}", mo["Name"]);
                    }

                    searcher = new ManagementObjectSearcher("select * from Win32_DiskDrive");
                    foreach (ManagementObject mo in searcher.Get())
                    {
                        Console.WriteLine("Disk Drive: {0}", mo["Caption"]);
                    }

                    searcher = new ManagementObjectSearcher("select * from Win32_BaseBoard");
                    foreach (ManagementObject mo in searcher.Get())
                    {
                        Console.WriteLine("Motherboard: {0}", mo["Product"]);
                    }
                    Console.ReadLine();
                }
                static void PC_Auslastung()
                {
                    // PC_Auslastung
                }
            } while (Schleife == true);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
        }
    }
}
