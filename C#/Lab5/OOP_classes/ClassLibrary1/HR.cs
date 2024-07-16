namespace ClassLibrary1
{
    public class HR : Employee
    {
        public void Hire()    
        {
            Console.WriteLine("Hire method in HR class that inherit from Employee class");
        }
        public override string ToString()
        {
            return "HR class That hire new employees";
        }
    }
}
