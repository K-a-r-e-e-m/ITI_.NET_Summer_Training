using Day_10_EF_Lab.Entities;
using Day_10_EF_Lab.Models;

namespace Day_10_EF_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompanyContext db = new CompanyContext();
            #region ADD
            //// Create db if not exist or add data if exists
            //db.Database.EnsureDeleted();
            //db.Database.EnsureCreated();

            Instructor inst1 = new Instructor() { Name = "Kareem", Age = 20, Salary = 10000 };
            Instructor inst2 = new Instructor() { Name = "Ali", Age = 20, Salary = 14000 };

            Student stud1 = new Student() { Name = "Kareem", Age = 20 };
            Student stud2 = new Student() { Name = "Ali", Age = 20, DeptId = 2 };

            Department dep1 = new Department() { DeptName = "SD" };
            Department dep2 = new Department() { DeptName = "HR" };
            Department dep3 = new Department() { DeptName = "Unix" };

            Course c1 = new Course() { Name = ".NET course" };
            Course c2 = new Course() { Name = "NodeJS course" };

            inst1.Instructor_Courses.Add(new Instructor_Course { Course = c2 });
            inst2.Instructor_Courses.Add(new Instructor_Course { Course = c1 });

            stud1.Student_Courses.Add(new Student_Course { Course = c2 , Grade = 100});
            stud2.Student_Courses.Add(new Student_Course { Course = c1 , Grade = 80});

            // Add new employee to table Students  => local storage
            //db.Students.Add(stud1);
            //db.Departments.Add(dep1);
            db.Students.AddRange(stud1, stud2);
            db.Departments.AddRange(dep1, dep2, dep3);
            db.Instructors.AddRange(inst1, inst2);
            db.Courses.AddRange(c1, c2);

            #endregion

            #region READ
            //var depts = db.Departments.ToList();
            //var emps = db.Students.Include(d => d.Department).ToList();
            //var emps = db.Students.Include(d => d.Department).First();
            //Console.WriteLine( emps);
            //foreach (var emp in emps)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion


            #region Update
            //var emp = db.Students.Find(1);
            //emp.Name = "KAREEM HANY";
            //emp.Salary = 7000;
            //emp.Age = 20;

            //var e2 = new Student { StudentId = 2, Name = "ali alilo"};
            //db.Students.Update(e2);
            #endregion

            #region Delete
            //var emp = db.Students.Find(3);
            //db.Students.Remove(emp);
            #endregion


            // Affect changes to data base
            db.SaveChanges();
        }
    }
}
