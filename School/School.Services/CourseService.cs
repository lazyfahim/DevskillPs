using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Internal;
using School.Data;
using School.Models;

namespace School.Services
{
    public class CourseService : ICourseService
    {
        private ISchoolUnitOfWork _unitOfWork;
        public CourseService(ISchoolUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IList<Course> GetAllCourses()
        {
            return _unitOfWork.CourseRepository.Get().ToList();
        }

        public void AddCourse(Course course)
        {
            _unitOfWork.CourseRepository.Add(course);
            _unitOfWork.Save();
        }

        public IList<Course> CourseSearchForUser(int Id, string searchString)
        {
            return _unitOfWork.CourseRepository.Get(
                c => c.Students.Any( s => s.StudentId == Id ) == false
                && c.Title.Contains(searchString)
                ).ToList();
        }
    }
}