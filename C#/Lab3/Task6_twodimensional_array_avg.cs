using System;

namespace Task6_twodimensional_array_avg
{
    internal class Task6_twodimensional_array_avg
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows of grades: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter number of columns of grades: ");
            int col = int.Parse(Console.ReadLine());

            int[,] grades = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"Enter data of row number {i + 1} column number {j + 1}: ");
                    grades[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            // Print the matrix
            Console.WriteLine("Matrix:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{grades[i, j]} \t");
                }
                Console.WriteLine();
            }

            // Calculate and print the average of each column
            for (int i = 0; i < col; i++)
            {
                double sum = 0;
                for (int j = 0; j < row; j++)
                {
                    sum += grades[j, i];
                }
                double avg = sum / row;
                Console.WriteLine($"Average of column {i + 1} = {avg}");
            }
        }
    }
}
