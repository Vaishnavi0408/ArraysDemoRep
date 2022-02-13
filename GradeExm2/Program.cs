using System;

namespace GradeExm2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter grade");
            char grade = Convert.ToChar(Console.ReadLine());
            switch (grade)
            {
                case 'A':
                case 'a':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                case 'c':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                case 'd':
                    Console.WriteLine("Poor");
                    break;
                default:
                    Console.WriteLine("Invalid Grade");
                    break;
            }

        }
    }
}
