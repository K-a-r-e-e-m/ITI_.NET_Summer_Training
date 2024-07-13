namespace Calculator
{
    internal class SimpleCalculator
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            int op;

            Console.WriteLine("========================================");
            Console.WriteLine("1. Addation\n2. Subtraction\n3. Multiplicatoin\n4. Devision\n5. Modulus");
            Console.WriteLine("--------------------");
            Console.Write("Enter operation number you want to do: ");
            op = int.Parse(Console.ReadLine());
            if (op < 1 || op > 5)
            {
                Console.WriteLine("\nEnter correct operatoin value between 1 to 5!");
                return;
            }
            Console.Write("First number = ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Second number = ");
            num2 = int.Parse(Console.ReadLine());
            result = num1 + num2;


            switch (op)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine($"\nAddation operatoin\n{num1} + {num2} = {result}");
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine($"\nSubtraction operatoin\n{num1} - {num2} = {result}");
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine($"\nMultiplicatoin operatoin\n{num1} * {num2} = {result}");
                    break;
                case 4:
                    if (num2  == 0)
                    {
                        Console.WriteLine("Can't devide by zero");
                        break;
                    }
                    result = num1 / num2;
                    Console.WriteLine($"\nDivision operatoin\n{num1} / {num2} = {result}");
                    break;
                case 5:
                    result = num1 % num2;
                    Console.WriteLine($"\nModulus operatoin\n{num1} % {num2} = {result}");
                    break;
            }
            Console.WriteLine("=======================================");

        }
    }
}
