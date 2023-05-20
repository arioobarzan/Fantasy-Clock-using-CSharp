using System;

namespace First_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("plz enter a num:");
            string number = Console.ReadLine();
            x = int.Parse(number);

            x *= 3;

            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
