using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp.Examples
{
    class TestMutilDim
    {
        static void Main(string[] args)
        {
            int[,] numbers = {{1,2},{11,22},{111,222} };

            foreach (int i in numbers)
            {
                Console.Write(i + "\t");

            }

            Console.WriteLine();
            Console.WriteLine();

            //jagged array
            int[][] jaggedArray=new int[3][];
            jaggedArray[0] = new int[2] { 10, 20 };
            jaggedArray[1] = new int[3] { 10, 20,30 };
            jaggedArray[2] = new int[4] { 10, 20,30,40 };

            //Nested forloop used in jagged array.
            foreach (int [] i in jaggedArray)
            {
                foreach (var j in i)
                {
                    Console.Write(j+"\t");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
