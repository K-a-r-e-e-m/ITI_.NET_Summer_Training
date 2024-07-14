namespace do_while
{
    internal class task4_do_while
    {
        static void Main(string[] args)
        {
            int number, sum = 0, i = 0;
            do
            {
                Console.WriteLine($"Enter number {++i}");
                number = int.Parse(Console.ReadLine());
                sum += number;

            } while (sum < 100 && number != 0);
        }
    }
}
