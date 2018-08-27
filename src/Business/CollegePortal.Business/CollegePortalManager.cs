using AutoMapper;
using CollegePortal.Business.Dto;
using CollegePortal.Data.Context;
using CollegePortal.Data.Context.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CollegePortal.Business
{
    public class CollegePortalManager : ICollegePortalManager
    {
        private readonly ICollegePortalDataFactory collegePortalDataFactory;
        private readonly IMapper mapper;

        public CollegePortalManager(ICollegePortalDataFactory collegePortalDataFactory, IMapper mapper)
        {
            this.collegePortalDataFactory = collegePortalDataFactory;
            this.mapper = mapper;
        }

        public CourseDto AddCourse(CourseDto courseDto)
        {
            // TODO: add validation for dependencies
            var entity = mapper.Map<Course>(courseDto);

            collegePortalDataFactory.Courses.Add(entity);

            return mapper.Map<CourseDto>(entity);
        }

        public StudentDto AddStudent(StudentDto studentDto)
        {
            // TODO: add validation for dependencies
            var entity = mapper.Map<Student>(studentDto);

            collegePortalDataFactory.Students.Add(entity);

            return mapper.Map<StudentDto>(entity);
        }

        public void AddStudentCourse(StudentCourseDto courseDto)
        {
            // TODO: add validation for dependencies
            var entity = mapper.Map<StudentCourse>(courseDto);

            collegePortalDataFactory.StudentCourses.Add(entity);
        }

        public void DeleteCourse(CourseDto courseDto)
        {
            // TODO: add validation for dependencies
            var entity = mapper.Map<Course>(courseDto);

            collegePortalDataFactory.Courses.Delete(entity);
        }

        public void DeleteStudent(StudentDto studentDto)
        {
            // TODO: add validation for dependencies
            var entity = mapper.Map<Student>(studentDto);

            collegePortalDataFactory.Students.Delete(entity);
        }

        public void DeleteStudentCourse(StudentCourseDto courseDto)
        {
            var entity = mapper.Map<StudentCourse>(courseDto);

            collegePortalDataFactory.StudentCourses.Delete(entity);
        }

        public IEnumerable<CourseDto> GetCourses()
        {
            var results = collegePortalDataFactory
                .Courses.GetAll()
                .OrderBy(c => c.CourseName)
                .ToList();

            return mapper.Map<IEnumerable<CourseDto>>(results);
        }

        public IEnumerable<StudentCourseDto> GetStudentCourse(int studentId)
        {
            var results = collegePortalDataFactory
                .StudentCourses
                .GetAll()
                .Where(c => c.StudentId == studentId)
                .OrderBy(c => c.CourseId)
                .ToList();

            return mapper.Map<IEnumerable<StudentCourseDto>>(results);
        }

        public IEnumerable<StudentDto> GetStudents()
        {
            var results = collegePortalDataFactory
                .Students
                .GetAll()
                .OrderBy(c => c.FirstName)
                .ThenBy(c => c.Surname)
                .ToList();

            return mapper.Map<IEnumerable<StudentDto>>(results);
        }

        public void UpdateCourse(CourseDto courseDto)
        {
            var entity = mapper.Map<Course>(courseDto);

            collegePortalDataFactory.Courses.Update(entity);
        }

        public void UpdateStudent(StudentDto studentDto)
        {
            var entity = mapper.Map<Student>(studentDto);

            collegePortalDataFactory.Students.Update(entity);
        }
    }
}