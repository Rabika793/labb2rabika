//using System;


//namespace labb2rabika.cs
//{
//    internal class counter5
//    {

//        public int Count { get; private set; }
//        public counter5(int initialCount)
//        {
//            Count = initialCount;
//        }

//        public static counter5 operator ++(counter5 c)
//        {
//            c.Count++;
//            return c;
//        }
//        public static counter5 operator --(counter5 c)
//        {
//            c.Count--;
//            return c;
//        }
//        public override string ToString()
//        {
//            return $"Count: {Count}";
//        }
//    }

//    class program
//    {

//        static void Main(string[] args)
//        {

//            counter5 counter = new counter5(10);
//            Console.WriteLine("Initial " + counter);


//            ++counter;
//            Console.WriteLine("After ++ " + counter);


//            --counter;
//            Console.WriteLine("After -- " + counter);

//            Console.ReadKey();
//        }

//    }
//}


