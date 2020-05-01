using System.Collections.Generic;

namespace Devskill.Framework
{
    public class StudentService : IStudentService
    {
        private IStudentUnitOfWork _studentUnitOfWork;

        public StudentService(IStudentUnitOfWork studentUnitOfWork)
        {
            _studentUnitOfWork = studentUnitOfWork;
        }

        public void AddStudent(Student student)
        {
            
        }

        public void EditStudent(Student student)
        {
            
        }

        public Student GetStudent(int Id)
        {
            return new Student();
        }

        public IList<Student> GetStudents()
        {
            return new List<Student>();
        }

        public void AddGradeToStudent(int studentId,int subjectId,double grade)
        {
            
        }
    }
}