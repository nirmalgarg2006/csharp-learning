using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TestAbstraction
    {
        static void Main(string[] args)
        {
            Shape shape = new Square(4);
            Console.WriteLine($"Area : {shape.Area()}");
            Console.ReadLine();
        }
    }

    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Square : Shape
    {
        private int side;

        public Square(int x)
        {
            side = x;
        }
        public override double Area()
        {
            return side * side;
        }
    }
}
