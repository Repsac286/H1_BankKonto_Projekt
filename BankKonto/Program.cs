using Konto;

Dictionary<int,BankKonto> kunder = new Dictionary<int,BankKonto>();

//Opretter kunde 1
BankKonto kunde1 = new StandartKonto();
kunde1.setId(1);
kunde1.Saldo = 727.4;
kunde1.Name = "Per";
kunde1.TransaktionHistorik = new();

//Opretter kunde 2
BankKonto kunde2 = new PrimiumKonto();
kunde2.setId(2);
kunde2.Saldo = 1234.5;
kunde2.Name = "Casper";
kunde2.TransaktionHistorik = new();

kunder.Add(kunde1.getId(), kunde1);
kunder.Add(kunde2.getId(), kunde2);

login(kunder);
static void login(Dictionary<int, BankKonto> kunder)
{
    while (true)
    {
        Console.WriteLine("Venligst skiv password");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int output))
        {
            if (kunder.TryGetValue(output, out BankKonto value))
            {
                Console.Clear();
                openKonto(kunder,value);
            } else
            {
                Console.Clear();
                Console.WriteLine("Password not found");
            }
        } else
        {
            Console.Clear();
            Console.WriteLine("Password not found");
        }
    }
}


static void openKonto(Dictionary<int, BankKonto> kunder, BankKonto currentKonto)
{
    while (true)
    {
        Console.Clear();
        printKunde(currentKonto);
        Console.WriteLine("\n1. add money\n2. Transaktion Historik\n3. exit");
        string input = Console.ReadKey(true).KeyChar.ToString();
        if (input == "1")
        {
            //tilføj penge
            Console.Clear();
            input = null;
            while (true)
            {
                Console.WriteLine($"Saldo: {currentKonto.Saldo}\nSkriv antallet af penge du vil tilføje   (brug komma)");
                input = Console.ReadLine();
                if (int.TryParse(input,out int output_int) && input != "0")
                {
                    Console.Clear();
                    currentKonto.saldoTransaction(output_int);
                    currentKonto.TransaktionHistorik.Add(currentKonto.TransaktionHistorik.Count + 1,output_int);
                    break;
                } else if (float.TryParse(input, out float output_float) && input != "0")
                {
                    Console.Clear();
                    currentKonto.saldoTransaction(output_float);
                    currentKonto.TransaktionHistorik.Add(currentKonto.TransaktionHistorik.Count + 1, output_float);
                    break;
                } else
                {
                    Console.Clear();
                    if (input == "0") 
                    { 
                    
                        break;
                    }
                    Console.WriteLine("Indtast venligst et gyldigt beløb");
                }
            }
        } else if (input == "2")
        {
            //Transaktion Historik
            Console.Clear();
            transaktionHistorik(currentKonto);
        } else if (input == "3")
        {
            //vend tilbage til login
            Console.Clear();
            break;
        } else if (input == "0")
        {
            //skift bank navn
            Console.Clear();
            BankKonto.BankNavn = "Bank Nordjysk";
        }
    }
}

static void transaktionHistorik(BankKonto currentKonto)
{
    if (currentKonto.TransaktionHistorik.Count == 0)
    {
        Console.WriteLine("Der er ingen transaktioner");
    } else
    {
        foreach (var i in currentKonto.TransaktionHistorik)
        {
            Console.WriteLine($"Transaktion {i.Key}");
            Console.WriteLine($"Beløb {i.Value}kr.");
            Console.WriteLine("----------------------");
        }
    }
    Console.ReadKey();
    Console.Clear();
}

//metode der udskiver en kundes konto infomationer
static void printKunde(BankKonto kunde)
{
    Console.WriteLine($"Kunde {kunde.getId()} hos {BankKonto.BankNavn}");
    Console.WriteLine("ID:    " + kunde.getId());
    Console.WriteLine("Navn:  " + kunde.Name);
    kunde.kontoType();
    Console.WriteLine("Saldo: " + kunde.Saldo);
}