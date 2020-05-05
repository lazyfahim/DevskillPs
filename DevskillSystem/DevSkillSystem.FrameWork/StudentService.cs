using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DevSkillSystem.FrameWork
{
    public class StudentService:IStudentService,IDisposable
    {
        IStudentUnitOfWork _studentUnitOfWork;
        public StudentService(IStudentUnitOfWork studentUnitOfWork)
        {
            _studentUnitOfWork = studentUnitOfWork;
        }
        public void CreateStudent(Student student)
        {
            _studentUnitOfWork.StudentRepository.Add(student);
            _studentUnitOfWork.Save();
        }

        public Student GetStudent(int Id)
        {
            var student = _studentUnitOfWork.StudentRepository.Get(s => s.Id == Id,null
            ,i => i.Include(s => s.Gardes).ThenInclude(s => s.Subject),
            false).FirstOrDefault();
            return student;
        } 
        public IList<Student> GetAllStudent()
        {
            return _studentUnitOfWork.StudentRepository.GetAll();
        }
        public void EditStudent(Student student)
        {
            var studenttoedit = _studentUnitOfWork.StudentRepository.GetById(student.Id);
            studenttoedit = student;
            _studentUnitOfWork.Save();
        }
        public void MarkGrade(int studentId, int subjectId,double gradevalue)
        {
            var studenttoedit = _studentUnitOfWork.StudentRepository
            .Get(s => s.Id == studentId, null,
                i => i.Include(s => s.Gardes), 
                false)
            .FirstOrDefault<Student>();
            studenttoedit.Gardes.Add(new Grade{
                GradeValue = gradevalue,
                StudentId = studentId,
                SubjectId = subjectId
            });
            _studentUnitOfWork.Save();
        }
        public void DeleteStudent(int Id)
        {
            _studentUnitOfWork.StudentRepository.Remove(Id);
            _studentUnitOfWork.Save();
        }

        public void Dispose()
        {
            _studentUnitOfWork.Dispose();
        }
    }
}