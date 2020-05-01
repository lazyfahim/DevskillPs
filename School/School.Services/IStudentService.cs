using System.Collections.Generic;
using School.Models;

namespace School.Services
{
    public interface IStudentService
    {
        IList<Student> GetStudents(int pageIndex, int pageSize, string searchText=null, string sortText=null);
        void AddStudent(Student student);
        void EditStudent(Student student);
        void EnrollIntoCourse(int CourseId, int StudentId, bool PaymentComplete);
        void DeleteStudent(int Id);
        Student GetStudent(int Id);
    }
}