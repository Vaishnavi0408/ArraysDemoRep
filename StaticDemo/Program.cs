using System;

namespace StaticDemo
{
    class Program
    {
        class Demo
        {
            public int a = 10;
            public static int b = 10;

            public void increment()
            {
                a++;
                b++;
            }

            public void print()
            {
                Console.WriteLine("a= " + a);
                Console.WriteLine("b= " + b);
            }


        }


        static void Main(string[] args)
        {
            Demo d1 = new Demo();
            d1.increment();
            d1.print();

            Console.WriteLine("**************************");

            Demo d2 = new Demo();
            d2.increment();
            d2.print();

        }
        
    }
}
