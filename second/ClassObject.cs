using System;

namespace Classobj
{
    public class Car
    {
        public string name;
        public int price;
        public int year;

        public void Start()
        {
            Console.WriteLine("The car is started");
        }
        public void Stop()
        {
            Console.WriteLine("The car is Stop");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Car c = new Car();
            c.name = "BMW";
            c.price = 5000000;
            c.year = 2020;
            Console.WriteLine($"Name of car is {c.name},, price {c.price}");
            c.Start();
            c.Stop();
        }
    }
}