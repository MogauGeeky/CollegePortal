using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CollegePortal.Business.Dto
{
    public class StudentCourseDto
    {
        [Required][DisplayName("Student")]
        public int StudentId { get; set; }
        [Required][DisplayName("Course")]
        public int CourseId { get; set; }
    }
}