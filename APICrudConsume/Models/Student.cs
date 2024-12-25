using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace APICrudConsume.Models
{
    public class Student
    {

            public int studentId { get; set; }
            [Required]
            public string studentName { get; set; }

            [Required]
            public int age { get; set; }

            [Required]
            public string studentGender { get; set; }
            [Required]
            public int standard { get; set; }
    }

    
}
