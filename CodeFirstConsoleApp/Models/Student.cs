using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstConsoleApp.Models
{
    [Table("Students")]
    public class Student : Grade
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public Grade Grade { get; set; }
    }
}
