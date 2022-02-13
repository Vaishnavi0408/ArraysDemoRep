using System;

namespace ArraysDemoRep
{
    class Program
    {
        static void Main(string[] args)
        {
                int[] marks = new int[6];
                int total = 0;
                double avg;
                Console.WriteLine("Enter marks of 6 subjects");
                for (int i = 0; i < 6; i++)
                {
                    marks[i] = Convert.ToInt32(Console.ReadLine());
                    total = total + marks[i];
                }
                avg = total / 6;
                Console.WriteLine("Average is " + avg);
        }
    }
}
