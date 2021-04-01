using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWithoutDataBase.Configurations
{
    class CourseConfiguration : EntityTypeConfiguration<Course>
    {
        public CourseConfiguration()
        {

            HasMany(e => e.Tags)
            .WithMany(e => e.Courses)
            .Map(m => m.ToTable("TagCourses").MapLeftKey("Course_CourseID"));

            Property(x => x.Name).IsRequired().HasMaxLength(255);

            Property(x => x.Description).IsRequired().HasMaxLength(2000);

            HasRequired(x => x.Author).WithMany(x => x.Courses).HasForeignKey(x => x.AuthorID);

            HasMany(x => x.Tags).WithMany(x => x.Courses).Map(m => m.ToTable("Coursetags"));

            HasRequired(x => x.Cover).WithRequiredPrincipal(x => x.Course);
        }
    }
}
