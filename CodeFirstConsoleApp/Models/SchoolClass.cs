using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstConsoleApp.Models
{
    [Table("Classroom")]
    public class SchoolClass : Student
    {
        public int ClassroomNumber { get; set; }
        public string Teacher { get; set; }
    }
}
