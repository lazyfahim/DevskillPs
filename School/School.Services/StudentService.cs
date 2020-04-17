using System.Collections.Generic;
using System.Linq;
using School.Contracts;
using School.Data;
using School.Models;

namespace School.Services
{
    public class StudentService : IStudentService
    {
        private ISchoolUnitOfWork _schoolUnitOfWork;

        public StudentService(ISchoolUnitOfWork schoolUnitOfWork)
        {
            _schoolUnitOfWork = schoolUnitOfWork;
        }

        public IList<Student> GetStudents(int pageIndex, int pageSize, string searchText=null, string sortText=null)
        {
            return _schoolUnitOfWork.StudentRepository.Get().ToList();
        }

        public void AddStudent(Student student)
        {
            _schoolUnitOfWork.StudentRepository.Add(student);
            _schoolUnitOfWork.Save();
        }
    }
}