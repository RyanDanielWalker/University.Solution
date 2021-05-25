using System.Collections.Generic;

namespace University.Models
{
  public class Course
  {
    public Course()
    {
      this.JoinEntities = new HashSet<CourseDepartmentStudent>();
    }
    public int CourseId { get; set; }
    public string Name { get; set; }
    public int Number { get; set; }

    public int MyInt { get; set; }
    public virtual ICollection<CourseDepartmentStudent> JoinEntities { get; set; }

    public string NameNumber
    {
      get
      {
        return Name + Number;
      }
    }
  }
}