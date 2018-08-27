using System.ComponentModel.DataAnnotations.Schema;

namespace CollegePortal.Data.Context.Entities
{
    [Table("Student_Course")]
    public class StudentCourse
    {
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}