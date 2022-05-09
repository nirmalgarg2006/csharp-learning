using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp.OOPS
{
    abstract class Printer
    {
        public abstract void print();
        public virtual void printdoc()
        {
            Console.WriteLine("");
        }
        public void setprinter(string name)
        {
            Console.WriteLine(name +" printer");
        }

    }
    class Lazer : Printer
    {
        public override void printdoc()
        {
            //Lazer implementation
        }
        public override void print()
        {
            base.setprinter("LAZER");
            Console.WriteLine("Lazer printer printing.....");
        }
        public void colorprint()
        {
            Console.WriteLine("color print");
        }
    }
    class DotMatrix : Printer
    {
        public override void printdoc()
        {
            //DotMatrix implementation
        }
        public override void print()
        {
            base.setprinter("DOT MATRIX");
            Console.WriteLine("Dotmatrix printer printing.....");
        }
    }
    class TestPrinter
    {
        static void Main(string[] args)
        {
            //Printer lp = new Lazer();
            Lazer lp = new Lazer();
            lp.print();
            lp.colorprint();

            Printer dp = new DotMatrix();
            dp.print();
        }
    }
}
