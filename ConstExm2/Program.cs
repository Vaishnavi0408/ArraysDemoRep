using System;

namespace ConstExm2
{
    class Parent
    {
        public Parent()
        {
            Console.WriteLine("Parent Class Constructor");
        }

        ~Parent()
        {
            Console.WriteLine("Destructor Parent");
            Console.ReadLine();
        }
    }

    class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("Child Class Constructor");
        }

        ~Child()
        {
            Console.WriteLine("Destructor Child");
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            Console.ReadLine();
        }
    }
}
