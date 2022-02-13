using System;

namespace OverLoadExm
{
    class Program
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public double add(double a, double b)
        {
            return a + b;
        }
        public double add(double a, int b)
        {
            return a + b;
        }

        public double add(int a, double b)
        {
            return a + b;
        }
        public string add(string a, string b)
        {
            return a + " " + b;
        }

        public double add(double a)
        {
            return a + a;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.add(56, 23));
            Console.WriteLine(p.add(45.2, 96.3));
            Console.WriteLine(p.add(56, 23.7));
            Console.WriteLine(p.add(56.7, 23));
            Console.WriteLine(p.add(56));
            Console.WriteLine(p.add("Hello", "world"));
        }
    }
}
