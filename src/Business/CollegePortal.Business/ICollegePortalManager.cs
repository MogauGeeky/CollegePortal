using CollegePortal.Business.Dto;
using System.Collections.Generic;

namespace CollegePortal.Business
{
    public interface ICollegePortalManager
    {
        IEnumerable<StudentDto> GetStudents();

        StudentDto AddStudent(StudentDto studentDto);

        void UpdateStudent(StudentDto studentDto);

        void DeleteStudent(StudentDto studentDto);

        IEnumerable<CourseDto> GetCourses();

        CourseDto AddCourse(CourseDto courseDto);

        void UpdateCourse(CourseDto courseDto);

        void DeleteCourse(CourseDto courseDto);

        IEnumerable<StudentCourseDto> GetStudentCourse(int studentId);

        void AddStudentCourse(StudentCourseDto courseDto);

        void DeleteStudentCourse(StudentCourseDto courseDto);
    }
}