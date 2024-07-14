using System.Diagnostics.CodeAnalysis;

namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 3
            int sum = 0, min, max;
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            min = max = array[0];
            foreach (int item in array)
            {
                sum += item;
                if (item < min) min = item;
                if (item > max) max = item;
            }
            Console.WriteLine($"sum = {sum}\nmin = {min}\nmax = {max}");
        }
    }
}
