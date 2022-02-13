using System;

namespace ParamArgsDemo
{
    class MathClass
    {
        public void Average(params double[] no)
        {
            double total = 0;
            double avg = 0;

            for (int i = 0; i < no.Length; i++)
            {
                total = total + no[i];
            }

            avg = total / no.Length;

            Console.WriteLine("Average is " + avg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MathClass obj = new MathClass();

            obj.Average(89,56,78,96,10,13,6,10);
            obj.Average(4,19,6,54);
            obj.Average(30,98,12,9,69,77,10,3,28,78, 8,10,41,7);
        }
    }
}
