using System.Collections.Generic;
using System;

namespace University.Models
{
  public class Student
  {
    public Student()
    {
      this.JoinEntities = new HashSet<CourseStudent>();

    }

    public int StudentId { get; set; }
    public string Name { get; set; }
    public DateTime Enrollment { get; set; }
    public virtual ICollection<CourseStudent> JoinEntities { get; }
  }
}























