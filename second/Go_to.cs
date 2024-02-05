using System;

namespace Go_To
{
    class Program
    {
        public static void Main(string[] args)
        {
        Start:
            Console.Write("Enter a number:");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    {
                        Console.WriteLine("This is 1");
                        goto End;
                    }
                case 2:
                    {
                        Console.WriteLine("This is 2");
                        goto Start;
                    }
                
            }
            End:
            {
                Console.WriteLine("Here end of te program");
            }

        }
    }
}

