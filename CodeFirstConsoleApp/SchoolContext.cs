using CodeFirstConsoleApp.Models;
using System.Data.Entity;

namespace CodeFirstConsoleApp
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolDb")
        {
            Database.SetInitializer<SchoolContext>(new DropCreateDatabaseIfModelChanges<SchoolContext>());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<SchoolClass> SchoolClass { get; set; }
    }
}
