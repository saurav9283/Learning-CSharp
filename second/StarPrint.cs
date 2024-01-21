using System;

namespace StarPrint
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number to print pattern");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j <= i; j ++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}