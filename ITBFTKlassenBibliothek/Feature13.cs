using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBFTKlassenBibliothek
{
    internal class Feature13
    {
        internal static void Feature_13()
        {
            int option = 0;



            while (option != 2)
            {
                Console.Clear();
                Console.WriteLine("Dataipfad ausgabe\n");
                Console.WriteLine("1. Dateipfad Informationen");
                Console.WriteLine("2. Wiederholung verlassen");
                Console.WriteLine("3. Programm beenden");
                Console.Write("Wählen Sie eine Option: ");
                option = int.Parse(Console.ReadLine());



                if (option == 1)
                {
                    Console.Write("Geben Sie den Dateipfad ein: ");
                    string filePath = Console.ReadLine();



                    if (File.Exists(filePath))
                    {
                        FileInfo fileInfo = new FileInfo(filePath);
                        Console.WriteLine("Name: " + fileInfo.Name);
                        Console.WriteLine("Größe: " + fileInfo.Length + " Bytes");
                        Console.WriteLine("Erstellt am: " + fileInfo.CreationTime);
                        Console.WriteLine("Zuletzt geändert am: " + fileInfo.LastWriteTime);



                        Console.Write("Möchten Sie die Datei umbenennen oder löschen? (U / L / N): ");
                        string option2 = Console.ReadLine();



                        if (option2.ToUpper() == "U")
                        {
                            Console.Write("Geben Sie den neuen Dateinamen ein: ");
                            string newName = Console.ReadLine();
                            string newFilePath = Path.Combine(fileInfo.Directory.FullName, newName);



                            File.Move(filePath, newFilePath);
                            Console.WriteLine("Die Datei wurde umbenannt.");
                        }
                        else if (option2.ToUpper() == "L")
                        {
                            File.Delete(filePath);
                            Console.WriteLine("Die Datei wurde gelöscht.");
                        }
                        else if (option2.ToUpper() == "N")
                        {
                            Console.WriteLine("Keine Änderung vorgenommen.");
                        }
                        else
                        {
                            Console.WriteLine("Ungültige Option.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Die Datei existiert nicht.");
                    }
                }
                else if (option == 2)
                {
                    Console.WriteLine("Wiederholung verlassen.");
                    Console.Clear();   
                }
                else if (option == 3)
                {
                    Console.WriteLine("Programm beendet.");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Ungültige Option.");
                }
            }



            Console.ReadLine();
        }
    }
}
