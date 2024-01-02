using System;
using System.Net;
using System.Linq;

namespace BankAccount
{
    class Client
    {
        private int id;
        private String name;
        private String dateJoined;
        public int Id 
        {
            get { return id;}
            set { id = value; }
        }
        public String Name 
        {
            get { return name;}
            set { name = value; }
        }
        public String DateJoined 
        {
            get { return dateJoined;}
            set { dateJoined = value; }
        }

        public Client(int id, String name, String dateJoined) {
            this.Id = id;
            this.Name = name;
            this.DateJoined = dateJoined;
        }

    }
    class BankAccount 
    {
        private Object client;
        private int balance;
        private char type;
        public Object Client 
        {
            get { return client;}
            set { client = value; }
        }
        public int Balance 
        {
            get { return balance;}
            set { balance = value; }
        }
        public char Type 
        {
            get { return type;}
            set { type = value; }
        }

        public BankAccount(Object client, int balance, char type)
        {
            this.Client = client;
            this.Balance = balance;
            this.Type = type;
        }
        public void CheckBalance() {
            Console.WriteLine("Balance: {0}{1}", balance, type); //Composite foirmatting
        }
        public void Withdraw() {
            Console.WriteLine("Your balance is: {0}{1}", balance, type);
            Console.WriteLine("How much would you like to withdraw?");
            int newTotal = balance - Convert.ToInt32(Console.ReadLine().Replace("$", ""));
            if (newTotal >= 0) {
                Console.WriteLine("New balance is: {1}{0}", type, newTotal);
            } else {
                Console.WriteLine("Your balance would be negative, that cannot happen!");
            }
        }
        public void Deposit() {
            Console.WriteLine("Your balance is: {0}{1}", balance, type);
            Console.WriteLine("How much would you like to deposit?");
            int newTotal = balance + Convert.ToInt32(Console.ReadLine().Replace("$", ""));
            Console.WriteLine("New balance is: {1}{0}", type, newTotal);
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name for the account: ");
            Client clientInfo = new Client(1, Console.ReadLine(), "25/12/2024");

            BankAccount bankAccount = new BankAccount(clientInfo.Name, 150542, '$');
            
            Console.WriteLine("Account Owner: {0}", bankAccount.Client);
            
            Console.WriteLine("What would you like to do? (Balance, Withdraw, Deposit)");
            switch (Console.ReadLine())
            {
                case "Balance":
                    bankAccount.CheckBalance();
                    break;
                case "Withdraw":
                    bankAccount.Withdraw();
                    break;
                case "Deposit":
                    bankAccount.Deposit();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }

        //Tutorial
        /*private int myVar;
        public int MyProperty //property
        {
            get { return myVar; }
            set { myVar = value; }
        }
        public BankAccount(int myProperty) //constructor
        {
            this.MyProperty = myProperty;
        }
        public void Func() //method
        {
            //
        }
        static void Main(string[] args)
        { 
            BankAccount bankAccount = new BankAccount(12); //construct an object
            bankAccount.Func();
            Console.WriteLine(bankAccount.MyProperty);
        }*/
    }
}
