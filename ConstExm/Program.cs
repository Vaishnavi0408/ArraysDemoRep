using System;

namespace ConstExm
{
    class Employee
    {
        int empno;
        string ename, designation;

        public Employee()
        {
            Console.WriteLine("Default Constructor");
        }

        public Employee(int eno, string enm)
        {
            empno = eno;
            ename = enm;
            designation = "Not Known";
        }
        public Employee(int eno, string enm, string desig)
        {
            empno = eno;
            ename = enm;
            designation = desig;
        }

        public void Print()
        {
            Console.WriteLine("Empno = {0} , Ename = {1} , designation = {2}", empno, ename, designation);
        }

        ~Employee()
        {
            Console.WriteLine("Destructor Called");
            Console.ReadLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Print();

            Employee e2 = new Employee(1, "Mohit");
            e2.Print();

            Employee e3 = new Employee(2, "Smith", "HR");
            e3.Print();
            Console.ReadLine();

        }
    }
}
