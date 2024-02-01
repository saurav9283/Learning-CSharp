using System;

namespace class1
{
    public class _1stclass1
    {
        class Program
        {
            public static void Main(string[] args)
            {
                Console.Write("Enter your age:");
                int x = Convert.ToInt32(Console.ReadLine());
                if(x > 18)
                {
                    Console.WriteLine("yOU ARE ELIGIBLE");
                }
                else
                {
                    Console.WriteLine("nOT eNLGIBLE");
                }
            }
            
        }
    }
}
