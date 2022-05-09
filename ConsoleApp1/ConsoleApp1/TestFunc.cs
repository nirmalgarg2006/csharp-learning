using System;


namespace ConsoleApp1
{
    internal class TestFunc
    {
        static void Main(string[] args)
        {
            Func<int, int, int> Sum = add;
            Console.WriteLine(Sum(10, 10));

            Func<int> getRandomNumber = delegate ()
            {
                Random rm = new Random();
                return rm.Next(1, 100);
            };
            int output = getRandomNumber();
            Console.WriteLine(output);
            Console.ReadLine();
        }

        static int add(int x, int y)
        {
            return x + y;
        }
    }
}
