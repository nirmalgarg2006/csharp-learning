using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp.Examples
{
    //indexers are smart arrays. Created using this keyword.
    //indexer allows you to create a class like that can allows its items to be accessed an array.  
    //Instances of that class can be accessed using the [] array access operator.

    class Books
    {
        object [] bookdetails=new object[3];
        public object this[int i]
        {
            get
            {
                return bookdetails[i];
            }
            set
            {
                bookdetails[i] = value;
            }
        } 
    }
    class TestIndexers
    {
        static void Main(string[] args)
        {
            Books b = new Books();

            //Book object is indexed
            //using set
            b[0] = 101;
            b[1] = "Learning C#";
            b[2] = 500;

            //using get
            Console.WriteLine("Book ID: " + b[0]);
            Console.WriteLine("Book Name: " + b[1]);
            Console.WriteLine("Book Price: " + b[2]);

            Console.ReadLine();
        }
    }
}
