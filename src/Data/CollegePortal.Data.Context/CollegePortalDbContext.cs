using CollegePortal.Data.Context.Entities;
using System.Data.Entity;

namespace CollegePortal.Data.Context
{
    public class CollegePortalDbContext : DbContext
    {
        public CollegePortalDbContext() : base("name=CollegePortalConnection")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CollegePortalDbContext>());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
    }
}