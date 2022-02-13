using System;

namespace GradeExm
{
    class Program
    {
        static void Main(string[] args)
        {
            double marks;
            Console.WriteLine("Enter Total Marks:");
            marks = Convert.ToDouble(Console.ReadLine());
            
            if (marks >= 75)
            {
                Console.WriteLine("Distinction");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("First Class");
            }
            else if (marks >= 45)
            {
                Console.WriteLine("Second Class");
            }
            else if (marks >= 35)
            {
                Console.WriteLine("Pass Class");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
