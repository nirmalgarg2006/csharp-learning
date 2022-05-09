using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp.Examples
{
    class Circle
    {
        private float radius;        
        private const float PI = 3.14F;

        //readonly property. Area will be calculated and given as output.
        public float Area
        {
            get { return PI*radius*radius; }            
        }

        
        public float Radius
        {   
            //validation before initializing private variable radius
            set 
            { 
                if(value<=0)
                    Console.WriteLine("Radius cannot be 0 or -ve");
                else
                    radius = value;
            }
            get { return radius; }
        }

    }
    class TestProperty
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();            
            Console.WriteLine("Enter radius of the circle");
            float r = Convert.ToSingle(Console.ReadLine());
            c.Radius = r; 
            Console.WriteLine("Area of circle with radius {0} is {1}",r,c.Area);
            Console.ReadLine();
        }
    }
}
