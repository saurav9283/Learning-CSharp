using System;

namespace InheriTanceOOPS
{
    public class Employee // BASE CLASS
    {
        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public int id;
        public string name;

        public void DisplayDetail()
        {
            Console.WriteLine($"Name is {name} , ID is {id}");
        }
    }

    public class Manager : Employee // DERIVED CLASS
    {
        public Manager(int id, string name) : base(id,name)
        {
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Employee E = new Employee(1, "Saurav");
            E.DisplayDetail();
            Manager M = new Manager(2, "Ritesh");
            M.DisplayDetail();

        }
    }
}