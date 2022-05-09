using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp.OOPS
{
    class TestMethod
    {
        public void AddOne(ref int x)
        {
            x++;
            Console.WriteLine("x = {0}", x);
        }
        public int calc(int x1, int x2, out int add, out int multiply)
        {
            add = x1 + x2;
            multiply = x1 * x2;
            return 1;
        }

        public void Average(int id, params int[] list)
        {
            int total = 0;
            foreach (int i in list)
            {
                total += i;
            }
            Console.WriteLine("Average for {0} = {1} ", id, (total / list.Length));
        }
    }
    class TestMain
    { 
        static void Main(string[] args)
        {
            TestMethod tm = new TestMethod();
            int y = 10;            
            tm.AddOne(ref y);
            Console.WriteLine("y = {0}", y);
            Console.WriteLine();

            int res1, res2;
            res1 = res2 = 0;
            int val=tm.calc(10, 20, out res1, out res2);
            Console.WriteLine(res1+" "+res2+" "+val);
            Console.WriteLine();

            tm.Average(1,2, 3, 4);
            tm.Average(2,5, 6, 7, 8, 9, 10);
            tm.Average(3,10, 20);

            Console.Read();
        }
    }
}
