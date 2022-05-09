using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BasicConsoleApp.Examples
{
    //static constructor is only called once. static constructor does not have access modifier(private or public)

    class Language
    {
        private string lang;
        private static int count;
        private static StringBuilder sb; //For appending string
        static Language()
        {
            count = 0;
            sb = new StringBuilder();
        }
        public Language()//default instance constructor
        {
            
            lang = "CSharp";
            sb.Append(lang+"\n");
            count++;
        }
        public Language(string language) //instance constructor with one parameter
        {
            lang=language;
            sb.Append(lang+"\n");
            count++;
        }
        public int getCount()
        {
            return count;
        }
        public string getLanguages()
        {
            return sb.ToString();
        }

        //Destructor is written only once. No access modifier and no parameter.
        //It will transform into Finalize(). 
        //Automatically invoked by garbage collector whenever the class objects that are no longer needed in the application.
        //When C# compiles a destructor, the CIL code emitted will turn it into an override of the protected virtual Finalize() method.
        ~Language() 
        {
            
        }
    }

    class TestConstructors
    {
        static void Main(string[] args)
        {
            Language csharp = new Language(); //static and default instance constructor will be called.
            Language vb = new Language("VB.NET"); //constructor will one parameter will be called

            Console.WriteLine("Count of Languages: "+vb.getCount());
            Console.WriteLine("List of Langauges:\n"+ vb.getLanguages());

            Console.ReadLine();
        }
    }
}
