using System;

namespace part1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int x = Convert.ToInt32(Console.ReadLine());
            if(x < 6)
            {
                Console.WriteLine("Nuber is less then 6");
            }
            else
            {
                Console.WriteLine("Number is greater then 6");
            }
            
        }
    }
}