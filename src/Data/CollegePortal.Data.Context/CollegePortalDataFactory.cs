using CollegePortal.Data.Context.Entities;

namespace CollegePortal.Data.Context
{
    public class CollegePortalDataFactory : ICollegePortalDataFactory
    {
        protected readonly CollegePortalDbContext collegePortalDbContext;

        public CollegePortalDataFactory(CollegePortalDbContext collegePortalDbContext)
        {
            this.collegePortalDbContext = collegePortalDbContext;
        }

        public IRepository<Student> Students => new Repository<Student>(collegePortalDbContext);
        public IRepository<Course> Courses => new Repository<Course>(collegePortalDbContext);
        public IRepository<StudentCourse> StudentCourses => new Repository<StudentCourse>(collegePortalDbContext);
    }
}