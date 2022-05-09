using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp.Examples
{
    //structures are value type data type.
    struct Account
    {
        public int AccNumber;
        public string AccHolderName;
        public double Amount;

        //structs cannot have parameterless constructors
        public Account(int AccNumber,string AccHolderName,double Amount)
        {
            this.AccNumber = AccNumber;
            this.AccHolderName = AccHolderName;
            this.Amount = Amount;
        }
    }
    class TestStruct
    {
        static void Main(string[] args)
        {
            Account a = new Account(1100,"User1",100000);
            Console.WriteLine("Account Number: "+a.AccNumber);
            Console.WriteLine("Account Holder Name: "+a.AccHolderName);
            Console.WriteLine("Amount: "+a.Amount);
            Console.WriteLine();
        }
    }
}
