using Figgle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ITBFTKlassenBibliothek
{
    internal class Feature15
    {
        internal static void Feature_15()
        {
            // code
            double Byte;
            double Bit;
            bool Fehler;
            string Groeßen;

            Console.WriteLine(FiggleFonts.Slant.Render("Bits und Bytes"));
            Console.WriteLine("MenüPunkte:");
            Console.WriteLine("1. Bit nach Byte");
            Console.WriteLine("2. Größen rechner");
            Console.WriteLine("3. SubExit");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Wählen sie ein MenüPunkt aus");

            string auswahl = Console.ReadLine();
            if (auswahl == "1")
            {
                Console.WriteLine();
                Console.WriteLine("1.Bit nach Byte");
                Console.WriteLine("2.Byte nach Bit");
                auswahl = Console.ReadLine();
                if (auswahl == "1")
                {
                    // 1
                    Console.WriteLine("Geben sie Bit ein");
                    string sBit = Console.ReadLine();
                    Fehler = double.TryParse(sBit, out Bit);
                    Byte = Bit / 8;
                    Console.WriteLine($"Das ergebniss ist: {Byte}");
                }
                else if (auswahl == "2")
                {
                    // 2
                    Console.WriteLine("Geben sie Byte ein");
                    string sByte = Console.ReadLine();
                    Fehler = double.TryParse(sByte, out Byte);
                    Bit = Byte * 8;
                    Console.WriteLine($"Das ergebniss ist: {Bit}");

                }

            }
            else if (auswahl == "2")
            {
                Console.WriteLine("MenüPunkte: \n1. Tibit\n2. Gibit\n3. Mibit\n4. Kibit\n5. Bit\n6. Tbit\n7. Gbit\n8. Mbit\n9. Kbit\n10. Bit\n11. TByte\n12. GByte\n13. KByte\n14. Byte\n15. TiByte\n16. GiByte\n17. MiByte\n18. KiByte\n19. Byte \n20. ");
                
            }
            else if (auswahl == "3")
            {
                // Größem rechner
                Console.WriteLine("Programm wird beendet");
                Console.WriteLine("Geben sie eine taste ein");
                Console.ReadKey();
                ITBFTKlassenBibliothek.ITSubMenue.ITSubMenue1();
            }
            else if (auswahl == "4")
            {
                Environment.Exit(0);
            }
            else
            {

            }
        }
    }
}
