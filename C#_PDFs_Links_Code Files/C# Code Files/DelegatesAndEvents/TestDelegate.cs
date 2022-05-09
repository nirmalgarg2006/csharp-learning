using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace BasicConsoleApp.DelegatesAndEvents
{
    class TestDelegate
    {
        public delegate void write(String str);

        public static void WriteToConsole(string s)
        {
            Console.WriteLine(s+" is written to the console");
        }
        public static void WriteToFile(string s)
        {
            try
            {
                StreamWriter sw = new StreamWriter("text.txt");
                sw.WriteLine(s + "is written to the file");
                sw.Flush();
                sw.Close();
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }
        public static void WriteToDatabase(string s)
        {
            //code for storing s in database table
        }
        static void Main(string[] args)
        {
            //write w = new write(WriteToConsole);

            //single cast delegate can have return type. 
            write w = WriteToConsole; 
            //w.Invoke("Delegates and Events");
            //w("Delegates and Events");

            w += WriteToFile; //adding the reference (Multicast Delegate)
            w("Delegates and Events");

            w -= WriteToConsole; //Removing the reference

            w.Invoke("Events");

            Console.Read();
        }
    }
}
