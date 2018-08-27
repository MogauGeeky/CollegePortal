using AutoMapper;
using CollegePortal.Business.Dto;
using CollegePortal.Data.Context.Entities;

namespace CollegePortal.Business
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Course, CourseDto>().ReverseMap();
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<StudentCourse, StudentCourseDto>().ReverseMap();
        }
    }
}