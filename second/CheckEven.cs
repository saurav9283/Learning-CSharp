using System;

namespace EvenCheck
{
    public class Checking
    {
        class Program
        {
            public static void Main(string[] args)
            {
                Console.Write("Enter any Number :");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a % 2 == 0)
                {
                    Console.WriteLine($"{a} is a Even number");
                }
                else
                {
                    Console.WriteLine($"{a} is a Odd Number");
                }
            }
        }
    }
}