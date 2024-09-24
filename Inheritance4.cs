//using System;

//namespace labb2rabika.cs
//{
//    internal class Inheritance4
//    {

//        //parent class

//        public int Id { get; set; }
//        public string Name { get; set; }

//        public void Details()
//        {
//            Console.WriteLine("Name:{0} , Id:{1}", Name, Id);
//        }
//    }

//    //single inheritance
//    class Employee : Inheritance4
//    {
//        public int E_Id { get; set; }
//        public string E_Name { get; set; }
//        public void E_Details()
//        {

//            Console.WriteLine("Emp name:{0} , Emp Id:{1}", E_Name, E_Id);
//            Console.WriteLine("Person name:{0} , Person Id:{1}", Name, Id);
//        }
//    }

//    //Multilevel inheritance
//    class BOD : Employee
//    {
//        public string BOD_Name { get; set; }
//        public void BOD_Details()
//        {
//            Console.WriteLine("BOD name:{0}", BOD_Name);
//        }
//    }
//    //hierarchial inheritance
//    class Manager : Inheritance4
//    {
//        public string Manager_Name { get; set; }
//        public void Manager_Details()
//        {
//            Console.WriteLine("Manager name:{0}", Manager_Name);
//        }
//    }

//    class Program
//    {

//        static void Main(string[] args)
//        {
//            //for single inheritance
//            Employee emp = new Employee();
//            emp.Name = "Rabika Rijal";
//            emp.Id = 1;
//            emp.E_Name = "Rabikasssl";
//            emp.E_Id = 7;
//            emp.E_Details();

//            //for multilevel inheritance
//            BOD bod = new BOD();
//            bod.Name = "Prabha shrestha";
//            bod.Id = 123;
//            bod.E_Name = "Prabha shrestha";
//            bod.E_Id = 32;
//            bod.BOD_Name = "CEO";
//            bod.E_Details();
//            bod.BOD_Details();


//            Manager mng = new Manager();
//            mng.Name = "Maya Tamang";
//            mng.Id = 55;
//            mng.Manager_Name = "Ms Maya";
//            mng.Details();
//            mng.Manager_Details();
//            Console.ReadLine();
//        }

//    }
//}


