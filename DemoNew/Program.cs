using System;

namespace DemoNew
{
    class Employee
    {
        public int empno;
        public string ename, designation;
    }
    class AA
    {
        public void AcceptData(Employee e)
        {
            Console.WriteLine("Enter Employee Number");
            e.empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Emter Name");
            e.ename = Console.ReadLine();
            Console.WriteLine("Emter Designation");
            e.designation = Console.ReadLine();
        }

        public void PrintData(Employee e)
        {
            Console.WriteLine("Employee ID " + e.empno);
            Console.WriteLine("Employee Name " + e.ename);
            Console.WriteLine("Designation " + e.designation);
        }
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            AA mainobj = new AA();

            mainobj.AcceptData(obj);
            mainobj.PrintData(obj);
        }
    }
}
