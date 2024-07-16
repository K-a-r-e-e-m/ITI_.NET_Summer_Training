using ClassLibrary1;

namespace OOP_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter number of employee you want to create: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            Employee[] EmpArr = new Employee[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"*** Enter the data of employee {i + 1} ***");
                string name, genStr;
                int id, sl, salary, d, m, y;

                Console.Write("Enter name: ");
                name = Console.ReadLine();

                Console.Write("Enter ID number: ");
                id = int.Parse(Console.ReadLine());

                Console.Write("Enter security level: ");
                sl = int.Parse(Console.ReadLine());

                Console.Write("Enter Salary: ");
                salary = int.Parse(Console.ReadLine());

                Console.Write("Enter Hiring date (day/month/year): ");
                string[] date = Console.ReadLine().Split('/');
                d = int.Parse(date[0]);
                m = int.Parse(date[1]);
                y = int.Parse(date[2]);
                HD hiring_date = new HD(d, m, y);

                Console.Write("Enter Gender (male/female): ");
                genStr = Console.ReadLine().ToLower();
                Gender gender = new Gender();
                if (genStr == "male")
                    gender = Gender.Male;
                else
                    gender = Gender.Female;

                EmpArr[i] = new Employee(name, id, sl, salary, hiring_date, gender);
                Console.WriteLine();
            }
            Console.WriteLine("=========Data of Employees=========");
            foreach (Employee employee in EmpArr)
            {
                employee.Display();
            }
            Developer dev = new Developer();
            HR newHr = new HR();
            Console.WriteLine($"{dev}\n{newHr}");
            dev.Develop();
            newHr.Hire();

        }
    }
}
