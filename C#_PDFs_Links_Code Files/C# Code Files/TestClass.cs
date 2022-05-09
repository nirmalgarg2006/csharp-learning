using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp
{
    class Employee
    {
        public int ?empid=null;
        public string ename=null;
        public Employee(int empid,string ename)
        {
            this.empid = empid;
            this.ename = ename;
        }

        public override string ToString()
        {
            return empid + ":" + ename;
        }

        public string getEmps()
        {
            return empid + ":" + ename;
        }
    }
    class ArrayTest
    {
        int[] numbers = new int[] { 1, 2, 3, 4, 5 };

        int[] nums = { 10, 20, 30, 40, 50 };

        public void createArray()
        {
            string[] chars = new string[2];
            chars[0] = "A";
            chars[1] = "B";

            Employee[] emps = new Employee[3];
            emps[0] = new Employee(101, "Emp1");
            emps[1] = new Employee(102, "Emp2");
            emps[2] = new Employee(103, "Emp3");

            foreach (Employee item in emps)
            {
                Console.WriteLine(item.getEmps());
            }
        }


    }
    class TestClass
    {
        static void Main(string[] args)
        {
            ArrayTest obj = new ArrayTest();
            obj.createArray();
            Console.Read();
        }
    }
}
