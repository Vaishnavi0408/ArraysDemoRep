using System;

namespace NestedIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            char gender;
            Console.WriteLine("Enter age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter character for Male/Female");
            gender = Convert.ToChar(Console.ReadLine());
            if (age > 18 && gender == 'F')
            {
                Console.WriteLine("Eligible for basketball team");
            }
            else if (age > 21 && gender == 'M')
            {
                Console.WriteLine("Eligible for football team");
            }
            else
            {
                Console.WriteLine("Not eligible");
            }
        }
    }
}
