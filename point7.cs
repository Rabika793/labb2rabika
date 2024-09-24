//using System;


//namespace labb2rabika.cs
//{
//    internal class point7
//    {
//        public int X { get; set; }
//        public int Y { get; set; }

//        // Constructor
//        public point7(int x, int y)
//        {
//            X = x;
//            Y = y;
//        }

//        // Overloading the unary '-' operator
//        public static point7 operator -(point7 p)
//        {
//            return new point7(-p.X, -p.Y);
//        }

//        public override string ToString()
//        {
//            return $"Point({X}, {Y})";
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            point7 point1 = new point7(5, -3);

//            Console.WriteLine("Original Point: " + point1);

//            // Using the overloaded '-' operator
//            point7 point2 = -point1;

//            Console.WriteLine("Negated Point: " + point2);
//        }
//    }
//}


