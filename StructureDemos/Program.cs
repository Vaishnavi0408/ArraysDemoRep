using System;

namespace StructureDemos
{
    public enum Colors { Red, Blue = 844, Yellow, green }

    struct Book
    {
        public int bookid;
        public string bookname;

        public void Print()
        {
            Console.WriteLine("Book id =" + bookid + " Book Name = " + bookname);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Colors c = Colors.green;
            Console.WriteLine((int)c);

        }
    }
}
