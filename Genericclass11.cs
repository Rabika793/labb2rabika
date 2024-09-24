//using System;

//namespace labb2rabika.cs
//{
//    internal class Genericclass11
//    {

//        public class GenericClass11<T>
//        {
//            private T data;


//            public GenericClass11(T value)
//            {
//                data = value;
//            }


//            public void Display()
//            {
//                Console.WriteLine($"Data: {data}");
//            }


//            public T GetData()
//            {
//                return data;
//            }


//            public static void Swap<T>(ref T a, ref T b)
//            {
//                T temp = a;
//                a = b;
//                b = temp;
//            }
//        }

//        class Program
//        {
//            static void Main(string[] args)
//            {

//                GenericClass11<int> intInstance = new GenericClass11<int>(123);
//                intInstance.Display();
//                Console.WriteLine($"Retrieved Data: {intInstance.GetData()}");


//                GenericClass11<string> stringInstance = new GenericClass11<string>("Hello, World!");
//                stringInstance.Display();
//                Console.WriteLine($"Retrieved Data: {stringInstance.GetData()}");


//                int a = 10, b = 20;
//                Console.WriteLine($"Before Swap: a = {a}, b = {b}");
//                GenericClass11<int>.Swap(ref a, ref b);
//                Console.WriteLine($"After Swap: a = {a}, b = {b}");


//                string str1 = "First", str2 = "Second";
//                Console.WriteLine($"Before Swap: str1 = {str1}, str2 = {str2}");
//                GenericClass11<string>.Swap(ref str1, ref str2);
//                Console.WriteLine($"After Swap: str1 = {str1}, str2 = {str2}");

//                Console.ReadKey();
//           }
//        }
//    }
//}

