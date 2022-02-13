using System;

namespace InterfaceExm2
{
    interface IPrintable
    {
        void Print();
    }

    class Employee : IPrintable
    {
        int empno;
        string ename, designation;

        public Employee(int eno, string enm, string desig)
        {
            empno = eno;
            ename = enm;
            designation = desig;
        }

        public void Print()
        {
            Console.WriteLine(empno + "," + ename + "," + designation);
        }

    }

    class Student : IPrintable
    {
        int rollno;
        string name, course;

        public Student(int rno, string nm, string crs)
        {
            rollno = rno;
            name = nm;
            course = crs;
        }

        public void Print()
        {
            Console.WriteLine(rollno + "," + name + "," + course);
        }

    }
    class Program
    {
        public void PrintDetails(IPrintable obj)
        {
            obj.Print();
        }
        static void Main(string[] args)
        {
            Employee e = new Employee(1, "Smith", "HR");
            Student s = new Student(12, "Allen", "C#");
            Program p = new Program();
            p.PrintDetails(e);
            p.PrintDetails(s);
        }
    }
}
