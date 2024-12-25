using System;
using System.Collections.Generic;

namespace APINetCoreCrudOperation.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string StudentName { get; set; } = null!;

    public int Age { get; set; }

    public string StudentGender { get; set; } = null!;

    public int Standard { get; set; }
}
