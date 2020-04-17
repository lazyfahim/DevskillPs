using Microsoft.EntityFrameworkCore;
using School.Models;

namespace School.Data
{
    public interface IAppContext
    {
        DbSet<Student> Students { get; set; }
        DbSet<Course> Courses { get; set; }
    }
}