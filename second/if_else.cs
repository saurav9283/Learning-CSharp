using System;

namespace part1
{
    internal class if_else
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x < 6)
            {
                Console.WriteLine("Number is less than 6");
            }
            else
            {
                Console.WriteLine("Number is greater than or equal to 6");
            }
        }
    }
}
