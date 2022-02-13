using System;

namespace Demo
{
    class Rectangle
    {
        public void Calculate(double l, double b, out double area, out double perimeter)
        {
            area = l * b;
            perimeter = 2 * (l + b);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            //var x = "Amit";
            //var y = 15;
            //x = "80";
            Rectangle r = new Rectangle();
            double l, b, a, p;
            Console.WriteLine("Enter Length and breadth");
            l = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            r.Calculate(l, b, out a, out p);
            Console.WriteLine("Area is " + a);
            Console.WriteLine("Perimeter is " + p);

        }
    }
}
