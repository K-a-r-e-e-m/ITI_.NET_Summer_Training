namespace ClassLibrary1
{
    public class Developer : Employee
    {
        public void Develop()
        {
            Console.WriteLine("Develop method in Developer class that inherit from Employee class");
        }
        public override string ToString()
        {
            return "Developer class that develop new apps";
        }

    }
}
