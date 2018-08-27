using CollegePortal.Data.Context.Entities;

namespace CollegePortal.Data.Context
{
    public interface ICollegePortalDataFactory
    {
        IRepository<Student> Students { get; }
        IRepository<Course> Courses { get; }
        IRepository<StudentCourse> StudentCourses { get; }
    }
}