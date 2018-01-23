using ConsoleApp11.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Configurations
{
    public class CourseConfiguration : EntityTypeConfiguration<Course>
    {
        public CourseConfiguration()
        {
            HasKey(p => p.Id);
            HasMany(p => p.ChildrenCourses)
                .WithOptional(p => p.ParentCourse)
                .HasForeignKey(p => p.ParentId);
        }
    }
}
