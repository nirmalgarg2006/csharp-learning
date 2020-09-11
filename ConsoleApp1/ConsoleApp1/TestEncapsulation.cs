using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TestEncapsulation
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee()
            {
                Name = "Nirmal",
                Age = 34
            };

            Console.WriteLine($"Name : {emp.Name}");
            Console.WriteLine($"Age : {emp.Age}");
            Console.ReadLine();
        }
    }

    public class Employee
    {
        private string name;
        private int age;

        
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
    }
}
