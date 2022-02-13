using System;

namespace DemoClass
{
    class Date
    {
        public int day, month, year;
    }

    class ManipulateDate
    {
        public void AcceptDate(Date d)
        {
            Console.WriteLine("Enter day");
            d.day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Month");
            d.month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Year");
            d.year = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintData(Date d)
        {
            Console.WriteLine(d.day + "/" + d.month + "/" + d.year);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Date d = new Date();
            ManipulateDate obj = new ManipulateDate();
            obj.AcceptDate(d);
            obj.PrintData(d);
        }
    }
}
