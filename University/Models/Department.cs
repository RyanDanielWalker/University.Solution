using System.Collections.Generic;

namespace University.Models
{
  public class Department
  {
    public Department()
    {
      this.JoinEntities = new HashSet<CourseDepartmentStudent>();
    }
    public int DepartmentId { get; set; }
    public string Name { get; set; }
    // public int Number { get; set; }

    // public int MyInt { get; set; }
    public virtual ICollection<CourseDepartmentStudent> JoinEntities { get; set; }

    // public string NameNumber
    // {
    //   get
    //   {
    //     return Name + Number;
    //   }
    // }
  }
}