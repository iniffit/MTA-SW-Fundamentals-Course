using System;

namespace IntroducingCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = 10;
            x++;
            ++x;
            Console.WriteLine($"X equals {x}");

            int y = x++;
            Console.WriteLine($"Y equals {y}");

            int z = ++x;
            Console.WriteLine($"Z equals {z}");
        }
    }
}
