using System;
using System.Collections.Generic;

namespace GenericExm2
{
    class Employee
    {
        int empno;
        string ename, designation;

        public Employee(int eno, string enm, string desig)
        {
            empno = eno;
            ename = enm;
            designation = desig;
        }

        public override string ToString()
        {
            return empno + "," + ename + "," + designation;
        }

    }
    class Class1
    {
        static void Main(string[] args)
        {
            List<Employee> elist = new List<Employee>()
            {
                new Employee(1, "Smith", "Manager"),
                new Employee(2, "Allen", "Accountant"),
                new Employee(3, "Kathy", "Accountant"),
                new Employee(4, "King", "Peon"),
                new Employee(5, "Steven", "Administrator")
            };

            foreach (Employee e in elist)
            {
                Console.WriteLine(e);
            }

        }
    }
}
