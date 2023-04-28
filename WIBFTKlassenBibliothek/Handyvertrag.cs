bool exit = false;
bool crash = false;
string datenvolumenStr = "0";
string telefonnummer = "0";
string smsStr = "0";
while (!exit)
{
    Console.WriteLine("Willkommen beim Handy-Vertragsrechner!");
    Console.WriteLine("Geben Sie 'Exit' ein, um das Programm zu beenden.");
    Console.WriteLine("Geben Sie 'Subexit' ein, um das submenü zu verlassen.");
    do
    {
        Console.WriteLine("\nBitte geben Sie Ihre Telefonnummer ein:");
        telefonnummer = Console.ReadLine();
        double telefonnummer_double;
        crash = false;

        if (telefonnummer.ToLower() == "exit")
        {
            Environment.Exit(0);
        }
        else if (telefonnummer.ToLower() == "subexit")
        {
            exit = true;
            break;
        }
        else if (!double.TryParse(telefonnummer, out telefonnummer_double) && telefonnummer != "subexit")
        {
            Console.WriteLine("Falsche eingabe!");
            crash = true;
            Console.ReadKey();
        }
    } while (crash == true);
    if (telefonnummer.ToLower() == "subexit")
    {
        exit = true;
        break;
    }

    do
    {

        Console.WriteLine("Bitte geben Sie das Datenvolumen in GB ein:");
        datenvolumenStr = Console.ReadLine();
        double Datenvolumen_Double;
        crash = false;

        if (datenvolumenStr.ToLower() == "exit")
        {
            Environment.Exit(0);
        }
        else if (datenvolumenStr.ToLower() == "subexit")
        {
            exit = true;
            break;
        }
        else if (!double.TryParse(datenvolumenStr, out Datenvolumen_Double) && datenvolumenStr != "subexit")
        {
            Console.WriteLine("Falsche eingabe!");
            crash = true;
            Console.ReadKey();
        }
    } while (crash == true);
    if (datenvolumenStr.ToLower() == "subexit")
    {
        exit = true;
        break;
    }
    do
    {
        Console.WriteLine("Bitte geben Sie die Anzahl der SMS pro Monat ein:");
        smsStr = Console.ReadLine();
        double sms_Double;
        crash = false;

        if (smsStr.ToLower() == "exit")
        {
            Environment.Exit(0);
        }
        else if (smsStr.ToLower() == "subexit")
        {
            exit = true;
            break;
        }
        else if (!double.TryParse(smsStr, out sms_Double) && smsStr != "subexit")
        {
            Console.WriteLine("Falsche eingabe!");
            crash = true;
            Console.ReadKey();
        }
    } while (crash == true);
    if (smsStr.ToLower() == "subexit")
    {
        exit = true;
        break;
    }

    double datenvolumen = 0, smsAnzahl = 0;
    if (!double.TryParse(datenvolumenStr, out datenvolumen) || !double.TryParse(smsStr, out smsAnzahl))
    {
        Console.WriteLine("Ungültige Eingabe. Bitte geben Sie Zahlenwerte ein.\n");
        Console.ReadKey();
    }

    double kosten = 10 + (datenvolumen * 1) + (smsAnzahl * 0.05);
    Console.WriteLine("Die Kosten für den Vertrag mit der Telefonnummer {0} betragen {1} Euro.\n", telefonnummer, kosten);
    Console.WriteLine("Drücken sie eine beliebige taste um fortzufahren");
    Console.ReadKey();
    Console.Clear();
}
