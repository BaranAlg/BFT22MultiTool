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
                double value;
                int from, to;

                Console.WriteLine("Bitte wählen Sie die Ausgangseinheit:");
                Console.WriteLine("1. Tibit");
                Console.WriteLine("2. Gibit");
                Console.WriteLine("3. Mibit");
                Console.WriteLine("4. Kibit");
                Console.WriteLine("5. Bit");
                Console.WriteLine("6. Tbit");
                Console.WriteLine("7. Gbit");
                Console.WriteLine("8. Mbit");
                Console.WriteLine("9. Kbit");
                Console.WriteLine("10. Bit");
                Console.WriteLine("11. TByte");
                Console.WriteLine("12. GByte");
                Console.WriteLine("13. KByte");
                Console.WriteLine("14. Byte");
                Console.WriteLine("15. TiByte");
                Console.WriteLine("16. GiByte");
                Console.WriteLine("17. MiByte");
                Console.WriteLine("18. KiByte");
                Console.WriteLine("19. Byte");
                from = int.Parse(Console.ReadLine());

                Console.WriteLine("Bitte wählen Sie die Zieleinheit:");
                Console.WriteLine("1. Tibit");
                Console.WriteLine("2. Gibit");
                Console.WriteLine("3. Mibit");
                Console.WriteLine("4. Kibit");
                Console.WriteLine("5. Bit");
                Console.WriteLine("6. Tbit");
                Console.WriteLine("7. Gbit");
                Console.WriteLine("8. Mbit");
                Console.WriteLine("9. Kbit");
                Console.WriteLine("10. Bit");
                Console.WriteLine("11. TByte");
                Console.WriteLine("12. GByte");
                Console.WriteLine("13. KByte");
                Console.WriteLine("14. Byte");
                Console.WriteLine("15. TiByte");
                Console.WriteLine("16. GiByte");
                Console.WriteLine("17. MiByte");
                Console.WriteLine("18. KiByte");
                Console.WriteLine("19. Byte");
                to = int.Parse(Console.ReadLine());

                Console.WriteLine("Bitte geben Sie den Wert ein, den Sie umrechnen möchten:");
                value = double.Parse(Console.ReadLine());

                double result = value * Math.Pow(1024, from - 1) / Math.Pow(1024, to - 1);
                Console.WriteLine("Das Ergebnis ist: {0}", result);

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
