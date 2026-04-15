using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konto
{
    public abstract class BankKonto
    {
        private static string? bankNavn = "Bank DK";
        private int id;
        private double saldo;
        private string name;

        public BankKonto(int id = 0, double saldo = 0.0, string name = "John")
        {
            this.id = id;
            this.saldo = saldo;
            this.name = name;
        }


        public int getId() 
        {
            return (this.id);
        }

        public void setId(int id) 
        { 
            this.id = id;
        }


        public double Saldo
        {
            get
            {
                return (this.saldo);
            }
            set
            {
                this.saldo = value;
            }
        }

        public string Name
        {
            get 
            {
                return this.name; 
            }
            set
            {
                this.name = value;
            }
        }

        public static string ?BankNavn
        {
            get
            {
                return (bankNavn);
            }
            set
            {
                bankNavn = value;
            }
        }


        public void saldoTransaction(int value)
        {
            this.saldo += value;
        }

        public void saldoTransaction(float value)
        {
            this.saldo += value;
        }

        public virtual void kontoType()
        {
            Console.WriteLine("Konto type");
        }
    }

    public class StandartKonto:BankKonto
    {
        public override void kontoType()
        {
            Console.WriteLine("Standart konto");
        }
    }

    public class PrimiumKonto:BankKonto
    {
        public override void kontoType()
        {
            Console.WriteLine("Primium konto");
        }
    }
}
