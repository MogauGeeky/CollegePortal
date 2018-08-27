using System;
using System.ComponentModel;

namespace CollegePortal.Business.Dto
{
    public class StudentCourseInfoDto
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Surname")]
        public string Surname { get; set; }
        [DisplayName("Course Name")]
        public string CourseName { get; set; }
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }
        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }
    }
}