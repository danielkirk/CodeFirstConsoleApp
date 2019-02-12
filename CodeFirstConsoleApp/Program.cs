using CodeFirstConsoleApp.Models;

namespace CodeFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var Context = new SchoolContext())
            {
                var student = new Student() { StudentName = "Daniel" };
                var classroom = new SchoolClass() { ClassroomNumber = 312, StudentName = "Daniel", Teacher = "Mrs.Hendricks" };

                Context.Students.Add(classroom);
                Context.SaveChanges();

            }
        }
    }
}
