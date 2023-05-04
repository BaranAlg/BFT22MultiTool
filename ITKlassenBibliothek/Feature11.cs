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
                    foreach (var process in processes)
                    {
                        if (!string.IsNullOrEmpty(process.MainWindowTitle))
                        {
                            int index = Array.IndexOf(processes, process);
                            Console.WriteLine($"{index + 1}. {process.MainWindowTitle}");
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
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(FiggleFonts.Slant.Render("PC-Hardwareinformationen:"));
                    Console.WriteLine("-------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
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
                        Console.WriteLine("Disk Drive: {0} ({1} GB)", mo["Caption"], Math.Round(Convert.ToDouble(mo["Size"]) / (1024 * 1024 * 1024), 2));
                    }

                    searcher = new ManagementObjectSearcher("select * from Win32_BaseBoard");
                    foreach (ManagementObject mo in searcher.Get())
                    {
                        Console.WriteLine("Motherboard: {0}", mo["Product"]);
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Drücken Sie eine beliebige Taste zum Fortfahren.");
                    Console.ReadLine();
                    Console.Clear();
                }
                static void PC_Auslastung()
                {
                    Console.Clear();
                    PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                    PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");
                    while (!Console.KeyAvailable)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(FiggleFonts.Slant.Render("Pc-Auslastung:"));
                        Console.ForegroundColor = ConsoleColor.Green;
                        float cpuUsage = cpuCounter.NextValue();
                        float ramUsage = ramCounter.NextValue();

                        Console.WriteLine($"\n\n\n\nAuslastung: {cpuUsage:F2}%");
                        Console.WriteLine($"RAM-Übrig: {ramUsage}MB\n\n\n\n");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Drücken Sie eine beliebige Taste zum Fortfahren.");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                    }
                }
            } while (Schleife == true);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
        }
    }
}
