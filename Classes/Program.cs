using System;

namespace NameBankAccount
{
    class BankAccount 
    {
        static void Main(string[] args)
        {
            private int myVar;

            public int MyProperty
            {
                get { return myVar; }
                set { myVar = value; }
            }
            public BankAccount(int myProperty)
            {
                this.MyProperty = myProperty;
            }
            public static void Func()
            {
                Console.WriteLine("Hey it works");
            }
        }
    }
}
