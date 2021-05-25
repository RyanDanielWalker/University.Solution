using System.Collections.Generic;
using System;

namespace University.Models
{
  public class Student
  {
    public Student()
    {
      this.JoinEntities = new HashSet<CourseDepartmentStudent>();

    }

    public int StudentId { get; set; }
    public string Name { get; set; }
    public DateTime Enrollment { get; set; }
    public virtual ICollection<CourseDepartmentStudent> JoinEntities { get; }
  }
}























