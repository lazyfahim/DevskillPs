using Microsoft.EntityFrameworkCore;
using School.Contracts;
using School.Models;

namespace School.Data
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}