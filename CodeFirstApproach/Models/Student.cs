
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproach.Models
{
    public class Student
    {
        [Key]
        public int studentId { get; set; }
        [Column("Student_Name", TypeName = "varchar(100)")]
        public string name { get; set; }
        [Required]
        public int age { get; set; }

        [Column("Student_Gender", TypeName = "varchar(100)")]
        public string gender { get; set; }

        [Required]
        public int Standard { get; set; }
    }
}
