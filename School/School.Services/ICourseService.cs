using System.Collections.Generic;
using School.Models;

namespace School.Services
{
    public interface ICourseService
    {
        IList<Course> CourseSearchForUser(int Id,string searchString);
        void AddCourse(Course course);
        IList<Course> GetAllCourses();
    }
}