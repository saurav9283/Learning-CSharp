using System;

namespace RunningConstructor
{
    public class Person
    {
        public string name;
        public int age;

        public Person() // this is default constructor;
        {
            Console.WriteLine("Constructor is called");
        }

        public Person(string nameOfThePerson, int nameOfTheAge)
        {
            name = nameOfThePerson;
            age = nameOfTheAge;
        }

        public void Display()
        {
            Console.WriteLine($"Name of the person is :{name}  and age is {age}");
        }
    }
    class Program
    {
        public static void Main(string[] agrs)
        {
            Person p = new Person();
            p.Display();
            Person p1 = new Person("Saurav", 22);
            p1.Display();
        }
    }
}