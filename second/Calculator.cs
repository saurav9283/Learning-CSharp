using System;

namespace Operation
{
    public class Calculator
    {
        public int sum(int x,int y)
        {
            return x + y;
        }
        public int subt(int x, int y)
        {
            return x - y;
        }

        public int multiply(int x , int y)
        {
            return x * y;
        }
        public int devide(int x , int y)
        {
            return x / y;
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            int x = 10;
            int y = 20;
            int summ = cal.sum(x, y);
            int subb = cal.subt(x, y);
            int multi = cal.multiply(x, y);
            int div = cal.devide(x, y);
            Console.WriteLine($"Sum for x: {x} and y: {y} is {summ}");
            Console.WriteLine($"Subtract for x: {x} and y: {y} is {subb}");
            Console.WriteLine($"Multiply for x: {x} and y: {y} is {multi}");
            Console.WriteLine($"Devide for x: {x} and y: {y} is {div}");

        }
    }
}