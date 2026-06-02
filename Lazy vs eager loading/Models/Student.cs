using System;
using System.Collections.Generic;

namespace StudentCourseLoadingDemo.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
