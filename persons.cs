// File: Person.Part2.cs
using System;

namespace PartialClassDemo
{
    public partial class Person
    {
        // Method to display first name
        public void DisplayFirstName()
        {
            Console.WriteLine($"First Name: {firstName}");
        }

        // Method to display last name
        public void DisplayLastName()
        {
            Console.WriteLine($"Last Name: {lastName}");
        }
    }
}
