using System;
using System.Collections.Generic;
using System.Linq;

namespace Devskill.Framework
{
    public class StudentService : IStudentService,IDisposable
    {
        private IStudentUnitOfWork _studentUnitOfWork;

        public StudentService(IStudentUnitOfWork studentUnitOfWork)
        {
            _studentUnitOfWork = studentUnitOfWork;
        }

        public void AddStudent(Student student)
        {
            _studentUnitOfWork.StudentRepository.Add(student);
            _studentUnitOfWork.Save();
        }

        public void EditStudent(Student student)
        {
            var studenttoedit = _studentUnitOfWork.StudentRepository.GetById(student.Id);
            studenttoedit = student;
            _studentUnitOfWork.Save();
        }

        public Student GetStudent(int Id)
        {
            return _studentUnitOfWork.StudentRepository.GetById(Id);
        }

        public IList<Student> GetStudents()
        {
            return _studentUnitOfWork.StudentRepository.GetAll();
        }

        public void AddGradeToStudent(int studentId,int subjectId,double gradeval)
        {
            var grade = new Grade()
            {
                StudentId = studentId,
                SubjectId = subjectId,
                GradeValue = gradeval
            };
            Student student = _studentUnitOfWork.StudentRepository.Get(st => st.Id == studentId,null, includeProperties: "Grades",false)
                .FirstOrDefault<Student>();
            if (student != null) student.Grades.Add(grade);
            _studentUnitOfWork.Save();
        }

        
        public void Dispose()
        {
            _studentUnitOfWork?.Dispose();
        }
    }
}