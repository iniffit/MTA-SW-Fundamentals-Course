using System;

namespace for_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            ForTest();
        }
        private static void ForTest()
        {
            for (int i = 1; i <= 5)
            {
                Console.WriteLine($"The value of i = {i}");
            }    
        }
    }
}
