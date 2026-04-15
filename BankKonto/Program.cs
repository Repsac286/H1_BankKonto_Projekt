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
printKunde(kunde1);
Console.WriteLine("");
printKunde(kunde2);

//ved "enter" klik ændre jeg bankens navn og udskiver begge kunders kontoer igen så man kan se ændringen
Console.ReadLine();
Console.Clear();
BankKonto.BankNavn = "Bank Nordjysk";

printKunde(kunde1);
Console.WriteLine("");
printKunde(kunde2);

//metode der udskiver en kundes konto infomationer
static void printKunde(BankKonto kunde)
{
    Console.WriteLine("Kunde " + kunde.getId() + " hos " + BankKonto.BankNavn);
    Console.WriteLine("ID:    " + kunde.getId());
    Console.WriteLine("Navn:  " + kunde.Name);
    kunde.kontoType();
    Console.WriteLine("Saldo: " + kunde.Saldo);
}