using System;
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

        public void EditStudent(Student student)
        {
            var st = _schoolUnitOfWork.StudentRepository.GetById(student.Id);
            st = student
            _schoolUnitOfWork.StudentRepository.Edit(st);
            _schoolUnitOfWork.Save();
        }

        public Student GetStudent(int Id)
        {
            var student = _schoolUnitOfWork.StudentRepository.GetById(Id);
            return student;
        }

        public void EnrollIntoCourse(int CourseId, int StudentId,bool PaymentComplete)
        {
            var student = _schoolUnitOfWork.StudentRepository.GetById(StudentId);
            student.Courses.Add(new StudentRegistration()
            {
                StudentId = StudentId,
                CourseId = CourseId,
                EnrollDate = DateTime.Now,
                IsPaymentComplete = false
            });
            _schoolUnitOfWork.StudentRepository.Edit(student);
            _schoolUnitOfWork.Save();
        }

        public void DeleteStudent(int Id)
        {
            _schoolUnitOfWork.StudentRepository.Remove(Id);
            _schoolUnitOfWork.Save();
        }
    }
}