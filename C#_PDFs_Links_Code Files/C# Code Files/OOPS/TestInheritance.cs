using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp.OOPS
{
    class Base
    {
        static Base()
        {

        }
        protected int i = 10;
        public void get()
        {
            Console.WriteLine("");
        }
        public Base()
        {
            Console.WriteLine("Base");
        }
        public Base(string str)
        {
            Console.WriteLine(str);
        }
        ~Base() { } //finalize()
    }
    class Derived:Base
    {
        public Derived()
        {
            Console.WriteLine("Derived");
        }
        public Derived(string s):base(s) //base class initialization
        {
            base.get();            
        }
        ~Derived() { }
    }
    class TestInheritance
    {
        static void Main(string[] args)
        {
            new Base();
            new Base();
            new Derived();
            new Derived("user");
        }
    }
}
