using System;

namespace CollegePortal.Business.Dto
{
    public class StudentCourseInfoDto
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string CourseName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}