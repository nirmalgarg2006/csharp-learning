using System;
using ValidateCreditCard;

namespace BasicConsoleApp
{     
    class Test
    {        
        static void Main(string[] args)
        {
            int custid;
            string number;

            Console.WriteLine("Enter customer id");
            custid=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the credit card number");
            number = Console.ReadLine();

            Validate v = new Validate();
            v.Creditcardnumber = number;
            Console.WriteLine("Customer "+custid+", you have "+v.validatecard());

            Console.Read();
        }
    }
}
