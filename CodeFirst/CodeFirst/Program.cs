using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public enum CouseLevel : byte
    {
        Beginner = 1,
        Advance = 2,
        Expert = 3
    }
    public partial class Course
    {
        public int CourseID { get; set; }
        public int AuthorID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public CouseLevel Level { get; set; }
        public short FullPrice { get; set; }
        public virtual Author Author { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
    public partial class Author
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }

    public partial class Tag
    {
        public int TagID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }

    public class PlutoContext : DbContext
    {
        public PlutoContext():base("name = PlutoConnection")
        { }
        DbSet<Course> courses { get; set; }
        DbSet<Author> Authors { get; set; }
        DbSet<Tag> Tags { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
