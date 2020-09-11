using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TestInheritence
    {
        public class A
        {
            private int value = 10;

            public class B : A
            {
                public int GetValue()
                {
                    return this.value;
                }
            }
        }

        /*Constructor from Base class to derived class
         * destructor from derived class to base class.
         * 
         * 
        */
        public class Animal
        {
            
            public Animal()
            {
                Console.WriteLine("Base Animal Class Constructor");
            }
            public virtual void Sound()
            {
                Console.WriteLine("Hello Animal");
            }

            public void MakeSound(string sound)
            {
                Console.WriteLine(sound);
            }

            ~Animal() { }
        }

        public class Cat : Animal
        {
            public override void Sound()
            {
                base.MakeSound("Meow");
                Console.WriteLine("Hello Cat");
            }

            ~Cat() { }
        }


        public class C : A
        {
            //    public int GetValue()
            //    {
            //        return this.value;
            //    }
        }


        /*
         * virtual or abstract method cannot be private.
         * */
        public abstract class ClassA
        {
            public abstract void Method1();
        }

        public class ClassB : ClassA
        {
            public override void Method1()
            {
                Console.WriteLine("abstract override method");
            }
        }

        static void Main(string[] args)
        {
            var b = new A.B();
            Console.WriteLine(b.GetValue());

            Cat cat = new Cat();
            cat.Sound();
           

            ClassA classA = new ClassB();
            classA.Method1();//this will not give any output as classA doesn't have anything in method 1


            Console.ReadLine();
        }
    }
}
