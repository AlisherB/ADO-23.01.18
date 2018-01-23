using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Classes
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public Monitor Monitor { get; set; }
        public virtual Course ParentCourse { get; set; }
        public virtual ICollection<Course> ChildrenCourses { get; set; }
    }
}
