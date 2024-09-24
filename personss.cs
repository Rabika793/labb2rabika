// File: Program.cs
using System;

namespace PartialClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Person
            Person person = new Person("Rabika", "Rijal");

            // Display full name
            person.DisplayFullName();

            // Display first name
            person.DisplayFirstName();

            // Display last name
            person.DisplayLastName();
            Console.ReadKey();
        }
    }
}
