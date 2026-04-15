using Konto;

//Opretter kunde 1
BankKonto kunde1 = new StandartKonto();
kunde1.setId(1);
kunde1.Saldo = 722.4;
kunde1.Name = "Per";

//Opretter kunde 2
BankKonto kunde2 = new PrimiumKonto();
kunde2.setId(2);
kunde2.Saldo = 1234.5;
kunde2.Name = "Casper";

kunde1.saldoTransaction(5);
kunde2.saldoTransaction(12.0f);

//Udskiver begge kunders kontoer
Console.WriteLine("Kunde 1 hos " + BankKonto.BankNavn);
Console.WriteLine("ID:    " + kunde1.getId());
Console.WriteLine("Navn:  " + kunde1.Name);
kunde1.kontoType();
Console.WriteLine("Saldo: " + kunde1.Saldo);

Console.WriteLine("\nKunde 2 hos " + BankKonto.BankNavn);
Console.WriteLine("ID:    " + kunde2.getId());
Console.WriteLine("Navn:  " + kunde2.Name);
kunde2.kontoType();
Console.WriteLine("Saldo: " + kunde2.Saldo);

//ved "enter" klik ændre jeg bankens navn og udskiver begge kunders kontoer igen så man kan se ændringen
Console.ReadLine();
Console.Clear();
BankKonto.BankNavn = "Bank Nordjysk";

Console.WriteLine("Kunde 1 hos " + BankKonto.BankNavn);
Console.WriteLine("ID:    " + kunde1.getId());
Console.WriteLine("Navn:  " + kunde1.Name);
kunde1.kontoType();
Console.WriteLine("Saldo: " + kunde1.Saldo);

Console.WriteLine("\nKunde 2 hos " + BankKonto.BankNavn);
Console.WriteLine("ID:    " + kunde2.getId());
Console.WriteLine("Navn:  " + kunde2.Name);
kunde2.kontoType();
Console.WriteLine("Saldo: " + kunde2.Saldo);
