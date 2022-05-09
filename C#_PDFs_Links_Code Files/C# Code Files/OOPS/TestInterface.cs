using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp.OOPS
{
    abstract class Employee
    {
       //protected methods and properties of Employee
    }
  
    class Manager : Employee, DAOFunctions
    {
        public void delete()
        {
            
        }

        public void insert()
        {
            
        }

        public void update()
        {
            
        }
    }
    class DAdmin : Employee, DAOFunctions
    {
        // If multiple interfaces contains same method, implementation will
        // have method with interface.
        // will not have public access specifier
        void DAOFunctions.delete()
        {
            
        }

        void DAOFunctions.insert()
        {
            
        }

        void DAOFunctions.update()
        {
            
        }
    }
    class TestInterface
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            
            DAOFunctions d = new Manager();
            
        }
    }
}
