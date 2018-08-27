using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CollegePortal.Business.Dto
{
    public class CourseDto
    {
        public int CourseId { get; set; }
        [Required]
        [DisplayName("Course Name")]
        public string CourseName { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }
    }
}