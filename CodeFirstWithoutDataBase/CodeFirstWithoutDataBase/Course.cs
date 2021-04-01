namespace CodeFirstWithoutDataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Courses")]
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            Tags = new HashSet<Tag>();
        }

        [Key]
        public int CourseID { get; set; }
        //[ForeignKey("Author")]
        public int AuthorID { get; set; }
        //[Required]
        //[MaxLength(2500)]
        public string Name { get; set; }
        //[Required]
        //[MaxLength(250)]
        public string Description { get; set; }
        public byte Level { get; set; }
        public short FullPrice { get; set; }
        public virtual Author Author { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public Cover Cover { get; set; }
    }
}
