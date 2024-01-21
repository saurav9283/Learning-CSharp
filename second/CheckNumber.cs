using System;

namespace CheckEvenNumber
{
    public class CheckNumber
    {
        public string CheckEven(int a)
        {
            if(a %2 == 0)
            {
                return "Number is Even";
            }
            else
            {
                return "Number is Odd";
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            var cal = new CheckNumber();

            Console.WriteLine(cal.CheckEven(6));
        }
    }
}