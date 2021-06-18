using System;

namespace ExamC
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 40;
            person.Name = "Amar";
            Console.WriteLine("Person details - Name = " + person.Name + ", Age = " + person.Age);
            Console.WriteLine("Person details (After incrementing age) - Name = " + person.Name + ", Age = " + (person.Age + 1));
        }
    }
}