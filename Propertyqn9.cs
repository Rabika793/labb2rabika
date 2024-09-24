//using System;

//namespace labb2rabika.cs
//{
//    internal class Propertyqn9
//    {
//        public string Name { get; set; }

//        // 2. Read-only property
//        public int YearOfBirth { get; }

//        // 3. Write-only property
//        private double _salary;
//        public double Salary
//        {
//            set { _salary = value; }
//        }

//        // 4. Computed property
//        public int Age
//        {
//            get { return DateTime.Now.Year - YearOfBirth; }
//        }

//        // 5. Indexed property
//        private int[] _scores = new int[5];
//        public int this[int index]
//        {
//            get { return _scores[index]; }
//            set { _scores[index] = value; }
//        }

//        // Constructor
//        public Propertyqn9(string name, int yearOfBirth)
//        {
//            Name = name;
//            YearOfBirth = yearOfBirth;
//        }

//        public void DisplayInfo()
//        {
//            Console.WriteLine($"Name: {Name}");
//            Console.WriteLine($"Year of Birth: {YearOfBirth}");
//            Console.WriteLine($"Age: {Age}");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Create an object of PropertyDemo
//            Propertyqn9 person = new Propertyqn9("Rabika", 1990);

//            // Auto-implemented property
//            person.Name = "Rabika";

//            // Write-only property
//            person.Salary = 50000;

//            // Indexed property
//            person[0] = 85;
//            person[1] = 90;

//            // Display information
//            person.DisplayInfo();
//            Console.WriteLine($"Score 1: {person[0]}");
//            Console.WriteLine($"Score 2: {person[1]}");
//            Console.ReadKey();
//        }
//    }
//}

