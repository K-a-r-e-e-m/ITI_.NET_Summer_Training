namespace ClassLibrary1
{
    public class Employee
    {
        string name;
        int id;
        int sl;
        Decimal salary;
        HD hiring_date;
        Gender gender;

        #region Constructor
        public Employee() { }
        public Employee(string _name)
        {
            name = _name;
        }
        public Employee(string _name, int _id) : this(_name)
        {
            id = _id;
        }
        public Employee(string _name, int _id, int _sl, Decimal _salary, HD _h, Gender _g) : this(_name, _id)
        {
            sl = _sl;
            salary = _salary;
            hiring_date = _h;
            gender = _g;
        }
            
        #endregion

        #region Property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Id { get; set; } // Auto property same as Name
        public int Sl
        {   // Get only for security level, No set accessor
            get { return sl; }
        }
        public Decimal Salary
        {
            get { return salary; }
            set
            {
                if (salary > 12000)
                    salary = value;
            }
        }
        public string SalaryFormatted
        {
            get { return String.Format($"{salary:C}"); }
        }


        public string getHD()
        {
            return hiring_date.ToString();
        }
        public void setHD(int _day, int _month, int _year)
        {
            hiring_date.day = _day;
            hiring_date.month = _month;
            hiring_date.year = _year;
        }
        #endregion

        public void Display()
        {
            Console.WriteLine($"Display method: ({name}, {id}, {sl}, {salary}, {hiring_date}, {gender})");
        }
        public override string ToString()
        {
            return $"ToString method: {name}, {id}, {sl}, {salary}, {hiring_date}, {gender}";
        }
    }
}
