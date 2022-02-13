using System;

namespace MultiDimenArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3];
            Console.WriteLine("Enter elements of 3*3 matrix");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Entered Matrix is ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
            }
        }
    }
}
