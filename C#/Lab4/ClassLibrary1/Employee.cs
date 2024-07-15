using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public struct Employee
    {
        string name;
        int id;
        int sl;
        Decimal salary;
        HD hiring_date;
        Gender gender;

        public Employee(string _name, int _id, int _sl, Decimal _salary, HD _h, Gender _g)
        {
            name = _name;
            id = _id;
            sl = _sl;
            salary = _salary;
            hiring_date = _h;
            gender = _g;
        }

        public string getName()
        {
            return name;
        }
        public void setName(string _name)
        {
            name = _name;
        }
        public int getId()
        {
            return id;
        }
        public void setId(int _id)
        {
            id = _id;
        }
        public int getSecurityLevel()
        {
            return sl;
        }
        public void setSecurityLevel(int _security_level)
        {
            sl = _security_level;
        }
        public string getSalary()
        {
            return String.Format($"Salary in currency format: {salary:C}");
        }
        public void setSalary(Decimal _salary)
        {
            if (_salary > 12000)
            {
                salary = _salary;
            }
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


