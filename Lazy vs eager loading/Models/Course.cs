using System;
using System.Collections.Generic;

namespace StudentCourseLoadingDemo.Models;

public partial class Course
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int? Studentid { get; set; }

    public virtual Student? Student { get; set; }
}
