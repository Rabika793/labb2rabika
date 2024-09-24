// File: Person.Part1.cs
using System;

namespace PartialClassDemo
{
    public partial class Person
    {
        // Fields
        private string firstName;
        private string lastName;

        // Constructor
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // Method to display full name
        public void DisplayFullName()
        {
            Console.WriteLine($"Full Name: {firstName} {lastName}");
        }
    }
}
