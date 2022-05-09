using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp.Examples
{
    class TestConversion
    {
        static void Main(string[] args)
        {
            // primitive types to objects. (Value type to reference type. Implicit Conversion)
            int i = 10;
            Console.WriteLine(i.ToString()); //Boxing

            //Reference type to value type (Explicit Conversion)
            object o = 100;
            int value = (int)o; //Unboxing
            Console.WriteLine(value);

            Console.WriteLine();

        }
    }
}
