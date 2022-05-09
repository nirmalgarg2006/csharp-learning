using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp.Examples
{
    //Enums are value type data type. index starts from zero. 
    //Index numbers can be changed. -ve values can be given
    //Only integer variations can be given as the type.
 
    class TestEnum
    {
        enum directions { East, West, North, South }; //default indexing
        enum priority:int {high=10,medium=5,low=1 } //changed index values

        static void Main(string[] args)
        {
            Console.WriteLine(directions.East+"\n"+directions.West+"\n"+directions.North+"\n"+directions.South);
            Console.WriteLine();

            Console.WriteLine(priority.high+"\n"+priority.medium+"\n"+priority.low);
            Console.WriteLine();

            //can be used in switch case
            char reply = 'y';
            do
            {
            Console.WriteLine("Enter priority number (10, 5 or 1)");
            int pnum = int.Parse(Console.ReadLine());
            switch (pnum)
            {
                case (int)priority.high:
                    Console.WriteLine("Priority is HIGH");
                    break;
                case (int)priority.medium:
                    Console.WriteLine("Priority is MEDIUM");
                    break;
                case (int)priority.low:
                    Console.WriteLine("Priority is LOW");
                    break;
                default:
                    Console.WriteLine("Invalid Priority Number");
                    break;
            }
            Console.WriteLine("Do you want to continue (y or n)?");
            reply = Convert.ToChar(Console.ReadLine().ToLower());
            }            
            while(reply != 'n');                                    
        }
    }
}
